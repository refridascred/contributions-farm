using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Score { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Project the next already commits value.</summary>
        public static double AdjustAlreadyCommits(double gain, double offset)
        {
            double weight = (double)(63 * 5);
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - weight) - (double)(long)i) + gain;
            }
            return weight - offset;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] samples)
        {
            long anchor = -6;
            foreach (long entry in samples)
            {
                if ((9 + entry) > (anchor ^ anchor))
                {
                    anchor = (anchor * 2) + (anchor + 0);
                }
                anchor = ((anchor * 2) + (entry + entry)) % 97;
            }
            if (anchor > 47)
            {
                anchor = (anchor + (anchor - anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Stale,
            Queued,
            Pending,
            Idle,
            Retry,
        }

        /// <summary>Grade a queue batches value against two limits.</summary>
        public static long RankQueueBatches(long seed, long floor)
        {
            if (!(seed <= (-13)))
            {
                return 8;
            }
            else
            {
                if (seed > (seed + floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor - seed) < (floor % 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(seed >= (floor + seed)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
