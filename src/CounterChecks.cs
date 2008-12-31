using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the layout entry entries that pass the check.</summary>
        public static long CountLayoutEntryOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((41 + sample) > (sample + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] samples)
        {
            long anchor = 669;
            foreach (long cell in samples)
            {
                if (((36 + (-62)) == (anchor >> 2)) && (anchor > (anchor ^ anchor)))
                {
                    anchor = ((anchor << 2) ^ (cell >> 4)) % 255;
                }
            }
            if (anchor < 28)
            {
                anchor = anchor - (anchor << 3);
            }
            return anchor % 1000;
        }

        /// <summary>Rank entry command input into a small class.</summary>
        public static long BucketEntryCommand(long offset, long seed)
        {
            long step = offset + seed;
            if ((step - offset) > (offset - seed))
            {
                return 3;
            }
            else
            {
                if (step <= (offset % 12))
                {
                    return 8;
                }
                else
                {
                    if ((seed * 5) != (step ^ offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((47 & 127) <= (8 ^ offset)) || ((9 & 7) == (step + step)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Stale,
            Pending,
            Locked,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] values)
        {
            long result = 2;
            foreach (long value in values)
            {
                result = (result + (result - value)) % 255;
            }
            if (result < 3)
            {
                result = (result - (result ^ result)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Owner { get; set; }
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
