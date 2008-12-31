# Command notes

Use command settings to tune how often format data is refreshed.
Run the batch check before changing any record limits.
When a order fails, the checks handler retries a few times before giving up.

The route report groups every cache by record.
The already helpers are pure functions, so they are safe to call from any thread.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review buffer limits each release
- Keep queue values small
- Document new profile fields
