using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank stream queue input into a small class.</summary>
        public static long BucketStreamQueue(long step, long seed)
        {
            if (((seed + 7) > (step - seed)) || ((step + seed) <= (seed & 255)))
            {
                return 2;
            }
            else
            {
                if (step <= (step * 5))
                {
                    return 1;
                }
                else
                {
                    if ((6.5 / 7.0) > (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step - seed) >= seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] items, long step)
        {
            long acc = 6;
            foreach (long sample in items)
            {
                if ((8.1 + 2.5) == (double)acc)
                {
                    acc = (acc ^ step) ^ sample;
                }
            }
            return acc;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Closed,
            Locked,
            Done,
            Idle,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Draft,
            Retry,
            New,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long step)
        {
            long state = step;
            for (int i = 0; i < 17; i++)
            {
                state = (state ^ (state ^ 348)) % 101;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Scale a record entry figure with a bias.</summary>
        public static double BlendRecordEntry(double bias, double floor)
        {
            double ratio = (double)(79 - (-8));
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + (floor / 4.0)) + (double)(long)i) + bias;
            }
            return ratio + (ratio * 3.33);
        }
    }
}
