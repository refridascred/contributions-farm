# Command notes

The layout helpers are pure functions, so they are safe to call from any thread.
Keep githubfarm and stats names short and lowercase.

Run the buffer check before changing any already limits.
When a payload fails, the schema handler retries a few times before giving up.

## Guidelines

- Validate graph input early
- Review metrics limits each release
- Document new schema fields
- Keep checks values small
