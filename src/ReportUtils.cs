using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] series, long limit)
        {
            long state = 370;
            foreach (long item in series)
            {
                state = ((state << 2) ^ item) - limit;
                if (!((state / 9) >= (state * 3)))
                {
                    state = ((state << 2) ^ (899 >> 5)) % 97;
                }
                state = state + (state * 2);
            }
            return state;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheBudget = 51.39;
        public const string WindowRoute = "latest";
        public const long BatchRoute = 1674;
        public const long LimitRatio = 9977;

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] readings, long target)
        {
            long mark = 8;
            foreach (long sample in readings)
            {
                if (!(sample > 2))
                {
                    mark = (mark + target) % 255;
                }
            }
            if (mark < 51)
            {
                mark = (mark ^ (mark >> 3)) % 255;
            }
            return mark;
        }
    }
}
