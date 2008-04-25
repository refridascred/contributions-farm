using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches <= sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Rank { get; set; }
            public bool Size { get; set; }
            public bool Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Retry,
            Stale,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] levels)
        {
            long score = 7;
            foreach (long entry in levels)
            {
                long next = score + (entry % 7);
                if (((double)next == (11.0 + 19.0)) && (next <= (score + score)))
                {
                    score = (score ^ (score + entry)) % 1000;
                }
                if ((score % 16) < entry)
                {
                    score = score ^ (entry - 413);
                }
                if (!((score & 127) > (entry * 2)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Total { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
