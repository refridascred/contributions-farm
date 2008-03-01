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

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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

        /// <summary>Count metrics payload pairs that satisfy a relation.</summary>
        public static long MatchMetricsPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
