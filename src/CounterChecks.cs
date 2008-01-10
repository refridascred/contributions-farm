using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long offset, long target)
        {
            if (!((5.2 - 7.8) > (double)offset))
            {
                return 2;
            }
            else
            {
                if ((target << 3) <= offset)
                {
                    return 3;
                }
                else
                {
                    if (((double)offset > (7.81 / 9.0)) || ((offset << 3) >= (target + target)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target - offset) >= (target / 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine editor buffer values into a single score.</summary>
        public static long TallyEditorBuffer(long[] data)
        {
            long score = 710;
            foreach (long sample in data)
            {
                if ((sample + score) >= sample)
                {
                    score = (score * 3) + (sample & 3);
                }
            }
            if (score > 4)
            {
                score = score ^ (score & 3);
            }
            return score % 65521;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Level { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                if (((mix << 2) <= (origin - origin)) && ((double)origin < 5.0))
                {
                    mix = mix ^ (15 & 127);
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((31 % 7) == (value & 31))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
