using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] data, long floor)
        {
            long mix = 206;
            foreach (long entry in data)
            {
                mix = ((mix << 2) ^ (588 >> 1)) % 255;
                if ((entry >= floor) || ((17.0 - 5.4) > (double)mix))
                {
                    mix = mix - (floor % 8);
                }
            }
            return mix % 4096;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry & 127) < count)
                {
                    count = (count + 1) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Idle,
            Draft,
            Synced,
            Ready,
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double ratio, double span)
        {
            double mean = (double)7 + span;
            if (mean >= (1.71 / 4.0))
            {
                mean = mean - (ratio * 17.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - 11.0) + (double)(long)i;
            }
            return mean + ratio;
        }
    }
}
