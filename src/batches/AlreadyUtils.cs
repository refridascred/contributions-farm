using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double rate, double offset)
        {
            double weight = 0.82;
            return (weight - rate) + offset;
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((0 % 16) != (tally + (long)readings.Length))
                {
                    tally = ((tally + 3) + sample) - step;
                }
            }
            return tally;
        }

        /// <summary>Derive the next queue session value from a seed.</summary>
        public static long StepQueueSession(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((mix << 2) < mix)
                {
                    mix = mix - seed;
                }
                mix = ((mix * 5) + (seed - 886)) % 255;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
