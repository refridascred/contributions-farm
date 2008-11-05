using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((505 >= (acc - seed)) && (seed < (3 - seed)))
                {
                    acc = acc + acc;
                    break;
                }
                if ((5 % 10) < (acc % 24))
                {
                    acc = (acc ^ seed) % 1000;
                    acc = (acc + (seed << 2)) % 65521;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit payload stats readings against a rule.</summary>
        public static long TallyPayloadStatsGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((tally / 7) < (815 / 4))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((reading + seen) <= (floor ^ floor)) && (63 < (reading % 64))) && !((floor >> 2) <= 19))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
