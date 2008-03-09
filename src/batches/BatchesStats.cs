using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Rank { get; set; }
            public double Label { get; set; }
            public string Owner { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Count profile layout pairs that satisfy a relation.</summary>
        public static long MatchProfileLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up schema command samples.</summary>
        public static long CompareSchemaCommandCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Ready,
            Paused,
        }
    }
}
