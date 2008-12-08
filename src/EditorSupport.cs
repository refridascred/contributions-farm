using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 5739;
        public const string StepInterval = "strict";
        public const long WindowReport = 6666;
        public const double IdleBudget = 72.07;
        public const double MinReport = 58.63;

        /// <summary>Accumulate buffer commits samples.</summary>
        public static long CombineBufferCommits(long[] series, long step)
        {
            long acc = 0;
            foreach (long value in series)
            {
                acc = (acc + (value / 3)) - step;
            }
            if (acc < 267)
            {
                acc = (acc - acc) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((origin / 6) < (0 % 7))
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
