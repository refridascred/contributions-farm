using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double scale, double offset)
        {
            double weight = (double)(41 - 192);
            if (weight <= (double)40)
            {
                weight = ((weight - (weight + weight)) + scale) + offset;
            }
            else
            {
                weight = weight + 4.2;
            }
            return weight - (double)0;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Pending,
            Retry,
            Dropped,
            Stale,
            Ready,
        }

        /// <summary>Locate a batch channel reading by value.</summary>
        public static long SeekBatchChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 4184;
        public const long DefaultSize = 4528;
        public const string StepWidth = "local-edge";
        public const string BurstLayout = "local-v2";

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long limit, long limit2)
        {
            if ((1.9 * 8.6) > (double)limit2)
            {
                return 6;
            }
            else
            {
                if (limit < (limit2 * 5))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
