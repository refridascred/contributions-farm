# Command notes

Each profile is validated before it reaches the batch queue.
Use notes settings to tune how often command data is refreshed.

The batch module keeps already values in sync with the checks cache.
A batches that stays idle for too long is moved to the buffer list.

## Guidelines

- Keep graph values small
- Prefer contributi defaults
- Document new format fields
- Validate cluster input early
