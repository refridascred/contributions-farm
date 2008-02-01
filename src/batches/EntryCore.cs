using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (floor < (floor % 2))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] series)
        {
            long result = 7;
            foreach (long sample in series)
            {
                result = ((result << 3) ^ result) % 97;
                for (int i = 0; i < 12; i++)
                {
                    result = result + ((long)i + sample);
                }
                if ((sample ^ sample) <= (sample % 12))
                {
                    result = result ^ (result % 24);
                }
            }
            if (result < 2)
            {
                result = (result + (result & 7)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double ratio, double span)
        {
            double weight = (double)(6 << 3);
            return ((weight + 5.4) + ratio) + span;
        }
    }
}
