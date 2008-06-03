# Payload notes

When a payload fails, the support handler retries a few times before giving up.
The profile module keeps format values in sync with the schema cache.
The route helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate buffer input early
- Keep batches values small
- Review contributi limits each release
- Prefer command defaults
