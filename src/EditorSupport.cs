using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] data)
        {
            long result = 73;
            foreach (long reading in data)
            {
                if (result <= 49)
                {
                    result = ((result << 2) ^ (result + result)) % 97;
                }
                else
                {
                    result = (result + reading) % 4096;
                }
            }
            return result;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a command editor counter forward.</summary>
        public static long StepCommandEditor(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardBudget = 56.29;
        public const double BatchSize = 26.05;
        public const long StepLevel = 4237;
    }
}
