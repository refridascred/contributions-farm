using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Dropped,
            New,
        }

        /// <summary>Rank window channel input into a small class.</summary>
        public static long GradeWindowChannel(long target, long floor)
        {
            if (floor > (floor * 2))
            {
                return 4;
            }
            else
            {
                if ((target << 2) != (floor + 227))
                {
                    return 8;
                }
                else
                {
                    if ((floor % 16) != (floor << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (target >= (floor << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next order contributi value.</summary>
        public static double SmoothOrderContributi(double scale, double bias)
        {
            double drift = (bias * 17.0) / 3.0;
            if (drift >= (scale - drift))
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift - (double)0;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (drift - 5.0);
        }
    }
}
