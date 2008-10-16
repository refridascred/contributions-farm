using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long step, long offset)
        {
            if (!((offset / 6) == (step & 3)))
            {
                return 6;
            }
            else
            {
                if ((step + 211) < (step - offset))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Failed,
            Ready,
            Active,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((42 + tally) <= (value << 3))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }
    }
}
