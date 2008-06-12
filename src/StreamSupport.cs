using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Synced,
            Draft,
            Closed,
            New,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Locked,
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
