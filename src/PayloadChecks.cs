using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (long)i;
                if (6.1 > (double)floor)
                {
                    mix = ((mix * 2) + (floor - floor)) % 97;
                }
                else
                {
                    mix = (mix ^ (mix & 255)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                result = ((result << 2) ^ (result - seed)) % 97;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long floor, long limit)
        {
            long diff = floor - limit;
            if ((limit & 63) <= limit)
            {
                return 5;
            }
            else
            {
                if ((54 - limit) <= diff)
                {
                    return 2;
                }
                else
                {
                    if ((258 + diff) >= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((diff >= (floor & 7)) || ((floor + floor) > limit))
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

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Idle,
            Locked,
            Queued,
        }

        /// <summary>Blend two support already measurements.</summary>
        public static double ScaleSupportAlready(double gain, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - scale) - (double)(long)i;
            }
            return scale + (gain + offset);
        }
    }
}
