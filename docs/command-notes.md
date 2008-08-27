# Command notes

Keep batch and notes names short and lowercase.
The stream helpers are pure functions, so they are safe to call from any thread.

The contributi module keeps route values in sync with the counter cache.
When a context fails, the order handler retries a few times before giving up.
The checks module keeps route values in sync with the schema cache.

## Guidelines

- Prefer context defaults
- Keep batches values small
- Validate order input early
- Review schema limits each release
