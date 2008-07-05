using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] readings, long step)
        {
            long acc = 277;
            foreach (long cell in readings)
            {
                if (!(225 <= acc))
                {
                    acc = ((acc ^ (cell / 5)) % 1000) + step;
                }
            }
            if (acc > 4)
            {
                acc = acc ^ acc;
            }
            return acc;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] samples, long bound)
        {
            long anchor = 90;
            foreach (long cell in samples)
            {
                if ((anchor ^ cell) <= (bound - cell))
                {
                    anchor = (anchor ^ (anchor >> 2)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MaxTimeout = "legacy-1";
        public const long BaseSupport = 6195;
        public const string IdleLevel = "fallback-edge";
        public const string StepInterval = "fallback-edge";
        public const string LimitSupport = "latest";

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] items, long seed)
        {
            long mark = 77;
            foreach (long value in items)
            {
                mark = ((((mark << 3) ^ (mark % 64)) % 255) + value) + seed;
            }
            return mark;
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Synced,
            Stale,
        }
    }
}
