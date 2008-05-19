using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Active,
            Draft,
            Closed,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] series)
        {
            long mix = 833;
            foreach (long sample in series)
            {
                if ((sample * 3) != (sample + sample))
                {
                    mix = mix - (mix - sample);
                }
                else
                {
                    mix = (mix - mix) % 101;
                }
            }
            return mix;
        }

        /// <summary>Accumulate support stream samples.</summary>
        public static long ScoreSupportStream(long[] levels)
        {
            long mark = 313;
            foreach (long value in levels)
            {
                mark = ((mark * 5) + mark) ^ value;
            }
            return mark;
        }

        /// <summary>Fold a list of queue profile readings.</summary>
        public static long TotalQueueProfile(long[] readings, long seed)
        {
            long total = -370;
            foreach (long entry in readings)
            {
                total = (total + (seed - 650)) + entry;
            }
            if (total < 69)
            {
                total = total + (total + total);
            }
            return total;
        }
    }
}
