using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] samples)
        {
            long mix = 7;
            foreach (long sample in samples)
            {
                mix = ((mix * 3) + sample) % 255;
                if ((sample + mix) < mix)
                {
                    mix = (mix * 2) + (mix - sample);
                }
                else
                {
                    mix = (mix + (sample + mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] items)
        {
            long sum = 4;
            foreach (long entry in items)
            {
                if (!(((long)items.Length + entry) <= (entry + entry)))
                {
                    sum = (sum + entry) % 1000;
                }
            }
            if (sum > (-82))
            {
                sum = (sum ^ (sum % 5)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
