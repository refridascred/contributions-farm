using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                if (sum < ((long)i + (long)i))
                {
                    sum = ((sum * 3) + (target << 1)) % 97;
                }
                else
                {
                    sum = sum + target;
                    sum = (sum + (target ^ target)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Failed,
            Active,
            Ready,
            Locked,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((3.21 / 4.0) > (double)(long)i))
                {
                    mix = (mix * 5) + (long)i;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine notes editor values into a single score.</summary>
        public static long TotalNotesEditor(long[] samples)
        {
            long anchor = 5;
            foreach (long item in samples)
            {
                if (54 >= (anchor + item))
                {
                    anchor = anchor ^ anchor;
                }
            }
            return anchor;
        }
    }
}
