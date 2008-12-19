using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] values)
        {
            long result = 9;
            foreach (long sample in values)
            {
                result = (result * 4) + result;
                result = (result + (18 - sample)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleFactor = 17.22;
        public const double BaseSize = 91.59;
        public const long RetryTools = 1905;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long offset, long bound)
        {
            long next = offset + bound;
            if (!((next ^ bound) <= (next + 1)))
            {
                return 0;
            }
            else
            {
                if (((-69) % 100) != (offset & 63))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of stats farm readings.</summary>
        public static long FoldStatsFarm(long[] series)
        {
            long mix = -97;
            foreach (long reading in series)
            {
                if (((mix + reading) > (reading - reading)) && ((mix * 3) == (long)series.Length))
                {
                    mix = ((mix << 2) ^ (mix - reading)) % 65521;
                }
                else
                {
                    mix = (mix ^ (reading + reading)) % 255;
                }
                mix = ((mix << 2) ^ (reading * 2)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] items, long offset)
        {
            long mark = 43;
            foreach (long item in items)
            {
                if (!((5.18 / 9.0) != (double)item))
                {
                    break;
                }
                mark = ((mark + item) % 1000) + offset;
            }
            return mark;
        }
    }
}
