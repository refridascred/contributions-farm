using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double scale, double floor)
        {
            double load = scale;
            if (load <= (9.0 / 6.0))
            {
                load = (load - (double)41) + floor;
            }
            return load - load;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double gain, double bias)
        {
            double mean = (double)202 + (gain / 2.0);
            if (mean <= (gain - 6.64))
            {
                mean = (mean - 3.0) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (gain + gain);
        }

        /// <summary>Count the schema contributi entries that pass the check.</summary>
        public static long AuditSchemaContributiHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen + seen) >= (seen + sample))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 3608;
        public const long SoftCommand = 103;
        public const long DefaultCommand = 8959;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
