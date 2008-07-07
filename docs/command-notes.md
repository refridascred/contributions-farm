# Command notes

When a batch fails, the filter handler retries a few times before giving up.
The metric report groups every window by schema.
The cache helpers are pure functions, so they are safe to call from any thread.

Keep command and schema names short and lowercase.
The layout module keeps metrics values in sync with the profile cache.
Run the metrics check before changing any batches limits.

## Guidelines

- Prefer commits defaults
- Review queue limits each release
- Keep batch values small
- Log every metrics change
