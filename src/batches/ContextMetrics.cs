using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of schema tools readings.</summary>
        public static long FoldSchemaTools(long[] samples, long offset)
        {
            long mark = -708;
            foreach (long entry in samples)
            {
                mark = (((mark * 3) + mark) % 1000) - entry;
                if ((30 / 4) < mark)
                {
                    mark = mark + (offset - offset);
                }
                else
                {
                    mark = ((mark * 3) + (offset + 2)) % 101;
                    mark = mark - (offset << 3);
                }
                mark = ((mark << 3) ^ (4 >> 5)) % 65521;
            }
            return mark;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long limit, long seed)
        {
            long step = limit ^ seed;
            if (897 >= (limit / 9))
            {
                return 2;
            }
            else
            {
                if (!((seed + seed) != (733 / 4)))
                {
                    return 0;
                }
                else
                {
                    if (((limit ^ 434) >= 522) && ((seed ^ 40) <= (step * 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
