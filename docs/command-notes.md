# Command notes

Use support settings to tune how often format data is refreshed.
Keep batch and already names short and lowercase.
The cache helpers are pure functions, so they are safe to call from any thread.

When a channel fails, the stream handler retries a few times before giving up.
Keep graph and window names short and lowercase.
Keep format and order names short and lowercase.

## Guidelines

- Keep batch values small
- Review buffer limits each release
- Document new window fields
- Prefer batch defaults
