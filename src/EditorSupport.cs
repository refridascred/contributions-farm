using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "strict-edge";
        public const long DefaultNotes = 7101;
        public const long StepFactor = 8725;

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultFarm = "legacy";
        public const double IdleFarm = 19.95;
        public const double BatchLevel = 47.57;

        /// <summary>Audit token githubfarm readings against a rule.</summary>
        public static long MeasureTokenGithubfarmHits(long[] values, long step)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((59 << 1) >= count)
                {
                    count = ((count + 2) - reading) - step;
                }
            }
            return count;
        }

        /// <summary>Check that every session editor entry stays within the limit.</summary>
        public static bool ValidateSessionEditorRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Offset { get; set; }
            public bool Weight { get; set; }
            public long Mode { get; set; }
        }
    }
}
