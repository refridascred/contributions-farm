# Command notes

The context helpers are pure functions, so they are safe to call from any thread.
When a support fails, the editor handler retries a few times before giving up.

The editor report groups every farm by route.
Run the notes check before changing any route limits.

## Guidelines

- Prefer githubfarm defaults
- Review channel limits each release
- Validate command input early
- Keep channel values small
