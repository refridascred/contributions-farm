# Command notes

Use order settings to tune how often profile data is refreshed.
The stream helpers are pure functions, so they are safe to call from any thread.

When a notes fails, the stream handler retries a few times before giving up.
When a channel fails, the entry handler retries a few times before giving up.
Run the editor check before changing any command limits.

## Guidelines

- Prefer filter defaults
- Validate queue input early
- Review report limits each release
- Keep metrics values small
