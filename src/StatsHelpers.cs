using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] data)
        {
            long result = 814;
            foreach (long entry in data)
            {
                if (entry > ((long)data.Length + entry))
                {
                    result = (result * 4) + (entry >> 1);
                }
                if (33 >= result)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] items, long limit)
        {
            long mix = -5;
            foreach (long sample in items)
            {
                mix = (mix * 5) + (mix - 92);
                if (((mix + limit) > limit) || (limit < (limit / 6)))
                {
                    mix = ((mix << 3) ^ (mix - sample)) % 255;
                }
            }
            if (mix < (-4))
            {
                mix = (mix - 84) % 255;
            }
            return mix;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long target, long step)
        {
            long bound = target + step;
            if (((target ^ step) >= (target - 327)) || ((91 + bound) == (step - 561)))
            {
                return 1;
            }
            else
            {
                if ((target < 0) && ((double)step == (8.9 / 2.0)))
                {
                    return 4;
                }
                else
                {
                    if (!(2.9 >= (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((4.0 + 1.5) >= (double)target) || ((target >> 3) > (step * 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
