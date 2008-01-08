using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a already queue value against two limits.</summary>
        public static long GradeAlreadyQueue(long offset, long step)
        {
            long delta = offset + step;
            if (((step * 5) <= (delta % 24)) && ((delta / 6) >= (step / 7)))
            {
                return 7;
            }
            else
            {
                if ((4 & 15) > (offset ^ step))
                {
                    return 5;
                }
                else
                {
                    if (delta >= step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long mix = 2;
            foreach (long item in levels)
            {
                if (((mix ^ mix) != (mix >> 5)) || ((item & 3) <= ((-40) - mix)))
                {
                    mix = mix - mix;
                }
            }
            if (mix < 63)
            {
                mix = (mix << 2) ^ mix;
            }
            return mix;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long seed, long target)
        {
            if (seed >= (target ^ 803))
            {
                return 2;
            }
            else
            {
                if ((911 - seed) > (seed << 1))
                {
                    return 4;
                }
                else
                {
                    if ((seed & 255) == (target - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed & 15) > (4 << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
