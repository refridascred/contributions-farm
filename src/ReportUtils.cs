using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] samples)
        {
            long anchor = 576;
            foreach (long item in samples)
            {
                if (((0 ^ item) != (anchor % 2)) && ((double)item <= (0.64 + 4.7)))
                {
                    anchor = anchor - ((long)samples.Length % 7);
                }
                anchor = anchor + item;
                anchor = (anchor - (anchor % 8)) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally >= (3 - tally)) || (entry >= (63 + entry)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] levels)
        {
            long mix = 3;
            foreach (long reading in levels)
            {
                mix = (mix + (mix * 5)) % 255;
                if ((double)reading >= (double)mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Locked,
            Stale,
            New,
            Draft,
        }
    }
}
