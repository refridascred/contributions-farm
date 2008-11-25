using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading << 1) == (reading - reading))
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

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] samples, long target)
        {
            long mix = 635;
            foreach (long value in samples)
            {
                if ((mix + value) <= (long)samples.Length)
                {
                    mix = (mix + (value - mix)) + target;
                }
            }
            return mix;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches - value) < floor)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 7; i++)
            {
                mix = mix + (offset - offset);
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 6861;
        public const string StepFactor = "strict-v2";
        public const long WindowAlready = 5914;
        public const long MinAlready = 1109;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Draft,
            Queued,
            Done,
        }
    }
}
