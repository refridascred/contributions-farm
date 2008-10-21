# Command notes

When a session fails, the graph handler retries a few times before giving up.
When a buffer fails, the buffer handler retries a few times before giving up.

The schema helpers are pure functions, so they are safe to call from any thread.
Run the layout check before changing any channel limits.
The commits module keeps channel values in sync with the route cache.

## Guidelines

- Validate farm input early
- Keep farm values small
- Document new token fields
- Prefer githubfarm defaults
