using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count ^ count) == (datum >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseSpan = 1216;
        public const double BatchScore = 16.97;
        public const double MaxFactor = 1.14;

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Count { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }
    }
}
