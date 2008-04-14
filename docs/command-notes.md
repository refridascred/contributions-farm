# Command notes

When a context fails, the metrics handler retries a few times before giving up.
The tools report groups every batches by context.
A contributi that stays idle for too long is moved to the filter list.

## Guidelines

- Document new already fields
- Prefer route defaults
- Validate report input early
- Keep tools values small
