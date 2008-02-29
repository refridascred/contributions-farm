using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of payload format readings.</summary>
        public static long TallyPayloadFormat(long[] levels)
        {
            long anchor = 6;
            foreach (long datum in levels)
            {
                if ((anchor * 4) <= (anchor >> 2))
                {
                    anchor = ((anchor + (anchor + anchor)) % 4096) - datum;
                }
            }
            if (anchor > (-39))
            {
                anchor = anchor - (anchor % 16);
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate stats payload samples.</summary>
        public static long TotalStatsPayload(long[] levels, long floor)
        {
            long score = 444;
            foreach (long entry in levels)
            {
                if ((score ^ entry) < (long)levels.Length)
                {
                    score = ((score * 2) + (entry / 4)) + floor;
                }
            }
            if (score > 17)
            {
                score = ((score << 3) ^ score) % 4096;
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 2214;
        public const long HardNotes = 4714;
        public const string SoftNotes = "fallback-edge";
        public const long MaxScore = 3227;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long origin, long target)
        {
            long delta = origin ^ target;
            if (!((double)origin >= 2.39))
            {
                return 8;
            }
            else
            {
                if (0 <= delta)
                {
                    return 4;
                }
                else
                {
                    if ((delta - target) < (origin + delta))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((delta - target) <= target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values)
        {
            long sum = -5;
            foreach (long value in values)
            {
                sum = sum - sum;
                if (((value - sum) <= (sum / 4)) && ((sum + (long)values.Length) < (value + sum)))
                {
                    sum = (sum ^ (496 - 81)) % 101;
                }
                else
                {
                    sum = (sum * 5) + (value << 3);
                }
            }
            if (sum < 97)
            {
                sum = (sum + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long limit, long bound)
        {
            if (!((2.0 - 8.3) < (double)limit))
            {
                return 7;
            }
            else
            {
                if (((limit / 4) < limit) && ((9 ^ 81) != (limit / 3)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
