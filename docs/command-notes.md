# Command notes

Run the entry check before changing any metric limits.
The batches module keeps notes values in sync with the stream cache.
The cache helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate metric input early
- Prefer context defaults
- Document new tools fields
- Keep tools values small
