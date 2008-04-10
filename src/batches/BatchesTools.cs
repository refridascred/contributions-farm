using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Mode { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Level { get; set; }
            public double Flag { get; set; }
        }
    }
}
