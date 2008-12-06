using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a contributi payload reading by value.</summary>
        public static long SeekContributiPayloadIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                if (!(sum >= (origin % 97)))
                {
                    sum = ((sum * 2) + (origin * 3)) % 101;
                    sum = sum ^ origin;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Stale,
            Active,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] series)
        {
            long anchor = -3;
            foreach (long entry in series)
            {
                anchor = anchor ^ (580 << 2);
                if ((anchor >= (entry + (-1))) && ((21 + entry) == (anchor / 6)))
                {
                    anchor = anchor + (anchor + (long)series.Length);
                }
                anchor = (anchor * 2) + ((-93) + entry);
                if ((double)entry >= 9.11)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "local-edge";
        public const long RetryGraph = 7890;
        public const long DefaultGraph = 6473;

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
