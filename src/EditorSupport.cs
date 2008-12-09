using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Locked,
            Idle,
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Fold a list of metrics format readings.</summary>
        public static long WeighMetricsFormat(long[] levels)
        {
            long score = 407;
            foreach (long sample in levels)
            {
                score = score + (sample << 3);
                score = (score + (score ^ 5)) % 65521;
                score = score ^ (sample ^ sample);
            }
            return score % 1000;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long bound, long floor)
        {
            if (((4.25 + 2.56) != (double)floor) || ((bound << 1) == (floor ^ 878)))
            {
                return 7;
            }
            else
            {
                if (((floor * 2) <= (floor - bound)) || ((7.0 + 17.0) < (double)bound))
                {
                    return 2;
                }
                else
                {
                    if (!((361 >> 1) >= (floor + bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
