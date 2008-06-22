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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((95 << 1) < reading)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
