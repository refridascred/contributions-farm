using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of order profile readings.</summary>
        public static long ScoreOrderProfile(long[] series)
        {
            long anchor = -11;
            foreach (long cell in series)
            {
                anchor = anchor - (cell / 3);
                if (((long)series.Length - 6) < anchor)
                {
                    anchor = ((anchor * 5) + (cell + (-60))) % 65521;
                    break;
                }
                if ((2 > ((-643) + cell)) && ((anchor ^ anchor) <= (cell % 10)))
                {
                    anchor = (anchor - (anchor ^ anchor)) % 4096;
                }
            }
            if (anchor > 294)
            {
                anchor = (anchor << 2) ^ (anchor & 127);
            }
            return anchor % 4096;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] data)
        {
            long mix = 33;
            foreach (long cell in data)
            {
                if ((13 ^ mix) >= mix)
                {
                    mix = mix - (cell + mix);
                }
                else
                {
                    mix = (mix ^ (mix * 4)) % 1000;
                }
                if ((mix - cell) == (cell << 1))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Owner { get; set; } = "";
            public double Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long floor, long step)
        {
            long next = floor + step;
            if ((6.0 + 1.0) < (double)step)
            {
                return 3;
            }
            else
            {
                if (!((floor % 7) == (next / 6)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowInterval = 622;
        public const long SoftSize = 7989;
        public const double WindowToken = 32.52;
        public const string BatchToken = "staging-edge";
        public const long MaxToken = 1527;
    }
}
