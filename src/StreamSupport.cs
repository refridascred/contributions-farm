using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long limit, long step)
        {
            if ((step / 8) < (566 + 4))
            {
                return 8;
            }
            else
            {
                if (((-17) + step) == (9 ^ limit))
                {
                    return 3;
                }
                else
                {
                    if (step > (43 >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)step < 10.0)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((19.0 / 9.0) != (double)target)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
