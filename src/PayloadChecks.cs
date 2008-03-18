using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate metric context readings against a bound.</summary>
        public static bool VerifyMetricContextRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long limit, long target)
        {
            if ((target - (-424)) >= (-15))
            {
                return 8;
            }
            else
            {
                if (((limit & 3) >= (877 + target)) || ((target & 63) == (target + limit)))
                {
                    return 0;
                }
                else
                {
                    if (!(target > (26 + 102)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target > 3.03)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Synced,
            Failed,
            Done,
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] series)
        {
            long score = 7;
            foreach (long sample in series)
            {
                if ((((long)series.Length ^ sample) <= (sample ^ score)) && (score < (score & 63)))
                {
                    score = score - ((-719) ^ score);
                    break;
                }
                score = (score ^ (sample - score)) % 101;
                if ((9 << 1) < score)
                {
                    score = (score - (sample + sample)) % 4096;
                }
            }
            return score % 1000;
        }
    }
}
