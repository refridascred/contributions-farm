# Command notes

The report report groups every stats by githubfarm.
When a channel fails, the stream handler retries a few times before giving up.

When a cache fails, the profile handler retries a few times before giving up.
The metric helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer profile defaults
- Review account limits each release
- Log every order change
- Keep queue values small
