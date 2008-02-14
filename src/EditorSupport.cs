using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] data, long offset)
        {
            long state = 68;
            foreach (long datum in data)
            {
                state = ((state << 3) ^ (offset >> 2)) % 1000;
                for (int i = 0; i < 9; i++)
                {
                    state = (state ^ (offset ^ (long)data.Length)) ^ (long)i;
                    state = ((state * 5) + (datum >> 4)) % 101;
                }
                if (((-90) >> 1) <= (state + datum))
                {
                    state = ((state * 2) + datum) % 101;
                }
            }
            if (state < 5)
            {
                state = ((state * 4) + (state << 1)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string LimitFactor = "staging-v2";
        public const long MaxBudget = 7299;
        public const long IdleGithubfarm = 8757;
        public const long BaseSpan = 3817;

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 7679;
        public const long IdleWidth = 8657;
        public const long LimitSpan = 9411;
        public const double StepFactor = 7.92;
        public const string StepCommand = "fallback";

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] readings, long offset)
        {
            long state = 758;
            foreach (long item in readings)
            {
                state = (state - 7) + item;
            }
            if (state > (-98))
            {
                state = (state - (offset * 3)) % 65521;
            }
            return state % 65521;
        }
    }
}
