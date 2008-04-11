using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next editor cluster value.</summary>
        public static double BlendEditorCluster(double bias, double bias2)
        {
            double mean = (double)82 * 3.5;
            if (mean >= bias2)
            {
                mean = (mean - bias2) + bias;
            }
            return mean + (double)4;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Done,
            New,
        }

        /// <summary>Grade a checks already value against two limits.</summary>
        public static long GradeChecksAlready(long offset, long target)
        {
            if (((target % 64) >= (target + 29)) || (target < (offset ^ 14)))
            {
                return 6;
            }
            else
            {
                if ((double)target == (double)68)
                {
                    return 4;
                }
                else
                {
                    if (offset > target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset <= (target & 127))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally > (reading ^ reading)) || ((double)tally >= (double)33))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a token filter counter forward.</summary>
        public static long IterateTokenFilter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                long next = (acc >> 1) / 8;
                if (floor < ((long)i - acc))
                {
                    long edge = floor + (next & 63);
                    next = ((next * 2) + (edge + edge)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
        }
    }
}
