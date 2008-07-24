# Command notes

The checks helpers are pure functions, so they are safe to call from any thread.
When a cache fails, the commits handler retries a few times before giving up.
Use command settings to tune how often cluster data is refreshed.

## Guidelines

- Log every window change
- Prefer githubfarm defaults
- Document new entry fields
