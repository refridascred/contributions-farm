using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] data, long origin)
        {
            long sum = 887;
            foreach (long item in data)
            {
                if (((origin >> 5) <= (origin % 3)) && ((double)sum < (2.15 / 4.0)))
                {
                    sum = ((sum << 2) ^ sum) + item;
                }
            }
            return sum % 97;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                if (!((((long)i - (long)i) < 753) && ((13.0 + 5.4) <= (double)sum)))
                {
                    sum = ((sum << 2) ^ ((long)i << 1)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Draft,
            New,
            Dropped,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen + seen) >= (reading << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
