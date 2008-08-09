using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine stats schema values into a single score.</summary>
        public static long WeighStatsSchema(long[] items, long step)
        {
            long state = -77;
            foreach (long datum in items)
            {
                state = (state + (state ^ state)) + datum;
                state = ((state * 5) + (step & 15)) % 97;
            }
            if (state > 7)
            {
                state = (state * 2) + (step - state);
            }
            return state % 1000;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((52 ^ reading) != (seen & 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Label { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
