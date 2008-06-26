using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a channel session pair into a bucket.</summary>
        public static long RankChannelSession(long step, long offset)
        {
            long delta = step - offset;
            if (step > (529 % 60))
            {
                return 8;
            }
            else
            {
                if (!((double)offset > (4.0 / 4.0)))
                {
                    return 5;
                }
                else
                {
                    if ((6 * 3) > delta)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the token schema series from a seed.</summary>
        public static long IterateTokenSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (((score * 5) + ((-44) + target)) % 255) + (long)i2;
                }
                if ((double)(long)i >= (4.0 + 3.78))
                {
                    score = score ^ (target - (long)i);
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
