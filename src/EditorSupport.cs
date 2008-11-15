using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!(((bound - bound) > (311 - 33)) && ((3.07 + 19.0) <= (double)hits)))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinPayload = "primary-edge";
        public const long StepTimeout = 8304;
        public const string MaxWidth = "local-edge";
        public const string CacheWidth = "open-edge";

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheSupport = 3.43;
        public const long CacheSize = 1386;
        public const double DefaultLevel = 34.71;

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
        }
    }
}
