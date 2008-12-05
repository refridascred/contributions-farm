using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor + (32 ^ anchor)) % 65521;
                if ((floor >> 4) == (floor << 2))
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank farm channel input into a small class.</summary>
        public static long BucketFarmChannel(long floor, long limit)
        {
            long bound = floor - limit;
            if ((limit ^ floor) <= (limit & 127))
            {
                return 7;
            }
            else
            {
                if ((12.0 / 9.0) <= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (((14 / 3) <= (bound * 2)) && ((double)limit != (8.0 / 7.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((364 + bound) > (limit & 63))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of buffer metric readings.</summary>
        public static long TotalBufferMetric(long[] series)
        {
            long sum = 77;
            foreach (long sample in series)
            {
                sum = ((sum << 3) ^ (sum + 5)) % 4096;
                if (((sample + sample) <= (sum + sample)) && ((872 - sample) == (8 / 6)))
                {
                    sum = (sum - sample) % 4096;
                }
            }
            if (sum > 30)
            {
                sum = sum + (sum - sum);
            }
            return sum;
        }

        /// <summary>Rank commits graph input into a small class.</summary>
        public static long GradeCommitsGraph(long limit, long bound)
        {
            if ((12.0 / 9.0) >= (double)bound)
            {
                return 4;
            }
            else
            {
                if (bound > (limit + bound))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit == (5.9 + 8.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound < limit)
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

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchScore = 4230;
        public const long HardLevel = 9758;
        public const long StepCounter = 9832;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Pending,
            Dropped,
            New,
        }
    }
}
