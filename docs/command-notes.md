# Command notes

Each tools is validated before it reaches the channel queue.
When a profile fails, the account handler retries a few times before giving up.
The context report groups every entry by metrics.

The editor helpers are pure functions, so they are safe to call from any thread.
Run the tools check before changing any command limits.

## Guidelines

- Review order limits each release
- Document new checks fields
- Validate route input early
- Prefer stream defaults
