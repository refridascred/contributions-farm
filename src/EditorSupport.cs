using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Pending,
            Failed,
            Closed,
            Queued,
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

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardBudget = 56.29;
        public const double BatchSize = 26.05;
        public const long StepLevel = 4237;
    }
}
