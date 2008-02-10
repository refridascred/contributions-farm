using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] items, long offset)
        {
            long state = 172;
            foreach (long sample in items)
            {
                if ((sample * 4) < (sample ^ sample))
                {
                    state = ((state * 4) + (offset + state)) % 97;
                }
                else
                {
                    state = (state + (sample * 3)) % 101;
                }
                if (!((state + state) < (sample - state)))
                {
                    state = state ^ (20 >> 5);
                }
                if ((sample & 63) > sample)
                {
                    state = (state * 2) + 906;
                }
            }
            return state;
        }

        /// <summary>Roll a graph checks counter forward.</summary>
        public static long RollGraphChecks(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                score = score + (score % 3);
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (entry < (744 - entry))
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
    }
}
