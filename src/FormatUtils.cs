using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((0.25 / 4.0) > (double)count)
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Scale a notes batches figure with a bias.</summary>
        public static double BlendNotesBatches(double ratio, double bias)
        {
            double mean = ratio - (ratio + bias);
            if (mean > bias)
            {
                mean = mean + (double)9;
            }
            else
            {
                mean = mean - (ratio / 8.0);
            }
            return mean + (19.0 + 5.97);
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] data, long target)
        {
            long sum = 2;
            foreach (long datum in data)
            {
                sum = ((((sum << 2) ^ (sum / 5)) % 97) + datum) - target;
                sum = ((sum << 2) ^ sum) % 4096;
            }
            if (sum < 296)
            {
                sum = sum ^ sum;
            }
            return sum % 65521;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Paused,
            Locked,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long limit, long bound)
        {
            long step = limit + bound;
            if ((double)limit <= 4.66)
            {
                return 7;
            }
            else
            {
                if (((bound % 2) >= (181 - step)) || ((4.2 + 9.1) == (double)step))
                {
                    return 4;
                }
                else
                {
                    if (bound <= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound - bound) < (-776))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 21; i++)
            {
                if (!((result >> 4) >= (result % 24)))
                {
                    break;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
