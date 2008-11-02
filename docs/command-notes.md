# Command notes

When a tools fails, the githubfarm handler retries a few times before giving up.
When a format fails, the cache handler retries a few times before giving up.
The context helpers are pure functions, so they are safe to call from any thread.

When a cluster fails, the editor handler retries a few times before giving up.
The layout helpers are pure functions, so they are safe to call from any thread.
The cluster helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep stats values small
- Prefer editor defaults
- Review tools limits each release
- Document new filter fields
