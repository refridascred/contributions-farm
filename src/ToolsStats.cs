using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Stale,
            New,
            Closed,
            Done,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings)
        {
            long result = 5;
            foreach (long entry in readings)
            {
                if (result < entry)
                {
                    result = (result + (result + entry)) % 4096;
                }
                if (entry <= (result & 255))
                {
                    result = (result * 3) + (result >> 1);
                }
                else
                {
                    result = result ^ (entry ^ result);
                }
            }
            if (result > 87)
            {
                result = (result ^ result) % 65521;
            }
            return result;
        }

        /// <summary>Roll a record support counter forward.</summary>
        public static long SeriesRecordSupport(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                if (!((1.5 / 6.0) < (double)target))
                {
                    state = (state + (state >> 5)) % 97;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
