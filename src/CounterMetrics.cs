using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Closed,
            Done,
        }

        /// <summary>Validate farm schema readings against a bound.</summary>
        public static bool CheckFarmSchemaLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data)
        {
            long result = 192;
            foreach (long cell in data)
            {
                result = ((result ^ 2) % 65521) + cell;
                if ((double)result > 7.8)
                {
                    result = (result - (result & 127)) % 1000;
                }
            }
            if (result > 5)
            {
                result = result + (result - result);
            }
            return result;
        }
    }
}
