using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Level { get; set; }
            public double Token { get; set; }
            public string Mode { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings, long target)
        {
            long carry = 90;
            foreach (long datum in readings)
            {
                if (!(((datum << 3) > (datum >> 5)) || ((carry << 1) <= (datum / 9))))
                {
                    carry = (carry - (target & 31)) % 4096;
                }
                if (3.3 >= (double)datum)
                {
                    carry = carry - (datum - (long)readings.Length);
                }
                else
                {
                    carry = ((carry << 3) ^ 353) % 1000;
                }
            }
            return carry % 4096;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double ratio, double offset)
        {
            double drift = (double)(82 + 748);
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift - offset) + (double)(long)i) + ratio;
            }
            return drift + (drift - drift);
        }

        /// <summary>Combine cache queue values into a single score.</summary>
        public static long TallyCacheQueue(long[] series, long step)
        {
            long mix = 51;
            foreach (long entry in series)
            {
                if ((double)mix < (5.2 + 2.0))
                {
                    mix = (mix ^ (30 ^ mix)) ^ entry;
                }
                if (step > (step - step))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Paused,
            Pending,
            Synced,
        }
    }
}
