using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Idle,
            Synced,
            Stale,
            Active,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)limit > (6.0 - 9.1))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Rank commits editor input into a small class.</summary>
        public static long RankCommitsEditor(long limit, long target)
        {
            if (((target & 7) > target) || ((96 - limit) >= (target ^ target)))
            {
                return 7;
            }
            else
            {
                if ((limit >> 5) == (target & 127))
                {
                    return 4;
                }
                else
                {
                    if ((target / 6) > (limit / 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((-65) << 1) < (limit + limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
