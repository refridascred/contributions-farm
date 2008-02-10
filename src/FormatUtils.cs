using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of record batch readings.</summary>
        public static long OverlapRecordBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of layout stream readings.</summary>
        public static long TallyLayoutStream(long[] samples, long origin)
        {
            long score = 61;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = ((score ^ (datum % 8)) % 4096) + (long)i;
                }
                if ((datum - score) > (score + datum))
                {
                    score = score ^ score;
                }
                else
                {
                    score = score - (score - datum);
                }
                if (511 >= (score << 3))
                {
                    score = (score - (777 * 4)) % 65521;
                }
            }
            if (score > 96)
            {
                score = (score ^ origin) % 4096;
            }
            return score;
        }

        /// <summary>Count the entry order entries that pass the check.</summary>
        public static long MeasureEntryOrderOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((bound + seen) > (bound + 9))
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Mode { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double gain, double floor)
        {
            double drift = 18.0;
            if (drift >= drift)
            {
                drift = (drift - (double)9) + floor;
            }
            else
            {
                drift = drift + drift;
            }
            return drift + (gain / 2.0);
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] levels)
        {
            long result = 97;
            foreach (long entry in levels)
            {
                result = ((result ^ 7) % 97) ^ entry;
            }
            return result;
        }
    }
}
