# Command notes

When a batches fails, the report handler retries a few times before giving up.
Run the order check before changing any window limits.
The route module keeps cache values in sync with the filter cache.

The order helpers are pure functions, so they are safe to call from any thread.
Keep metrics and editor names short and lowercase.

## Guidelines

- Log every window change
- Keep already values small
- Validate command input early
