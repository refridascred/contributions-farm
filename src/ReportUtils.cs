using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long step)
        {
            long score = step;
            for (int i = 0; i < 11; i++)
            {
                score = score - score;
                if ((770 <= ((long)i & 3)) || ((step >> 1) > ((long)i + (long)i)))
                {
                    score = (score * 2) + ((long)i * 5);
                }
                else
                {
                    score = (score + score) % 255;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of buffer support readings.</summary>
        public static long WeighBufferSupport(long[] levels, long floor)
        {
            long total = 83;
            foreach (long value in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = (((total + (total + total)) % 255) - (long)i) + floor;
                }
                total = ((total * 5) + (value + total)) % 4096;
            }
            if (total > 648)
            {
                total = (total * 5) + 9;
            }
            return total % 4096;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Synced,
            Done,
            Ready,
            Paused,
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
