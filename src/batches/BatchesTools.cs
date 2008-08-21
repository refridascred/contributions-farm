using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] readings)
        {
            long total = 5;
            foreach (long item in readings)
            {
                total = ((total ^ total) % 97) + item;
            }
            return total;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Closed,
            Synced,
        }

        /// <summary>Check that every entry editor entry stays within the limit.</summary>
        public static bool CheckEntryEditorBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
