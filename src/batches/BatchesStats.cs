using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit profile order readings against a rule.</summary>
        public static long TallyProfileOrderGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((17.0 / 7.0) != (double)value) || ((count + 29) != (3 * 2)))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Roll a already report counter forward.</summary>
        public static long IterateAlreadyReport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((4.37 + 7.19) > (double)limit)
                {
                    result = result ^ 76;
                }
                else
                {
                    result = (result ^ (result + limit)) % 97;
                }
                if (!(((long)i - result) >= result))
                {
                    result = (result * 5) + ((long)i * 3);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count editor tools pairs that satisfy a relation.</summary>
        public static long CompareEditorToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
