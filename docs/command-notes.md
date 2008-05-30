# Command notes

Keep channel and githubfarm names short and lowercase.
Use metric settings to tune how often githubfarm data is refreshed.

When a window fails, the channel handler retries a few times before giving up.
When a cache fails, the already handler retries a few times before giving up.
The graph helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review report limits each release
- Log every window change
- Prefer editor defaults
- Keep cache values small
