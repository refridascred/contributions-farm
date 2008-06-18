using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of token githubfarm readings.</summary>
        public static long TallyTokenGithubfarm(long[] series)
        {
            long anchor = 88;
            foreach (long value in series)
            {
                if ((2.58 * 5.52) == (double)value)
                {
                    anchor = ((anchor << 2) ^ (anchor / 6)) % 255;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Done,
            Active,
            Paused,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (104 >= (cell * 4))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (count <= (count % 24))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
