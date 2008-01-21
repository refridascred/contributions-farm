using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long score = -2;
            foreach (long cell in readings)
            {
                score = ((score * 2) + (116 ^ cell)) % 65521;
                if ((double)score == (5.5 * 5.1))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = ((total << 2) ^ ((long)i + total)) % 4096;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally + tally) == (tally ^ 70))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Idle,
            Pending,
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
