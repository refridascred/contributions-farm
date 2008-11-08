# Command notes

Each counter is validated before it reaches the window queue.
The stats report groups every githubfarm by session.
Keep token and session names short and lowercase.

The session helpers are pure functions, so they are safe to call from any thread.
When a layout fails, the filter handler retries a few times before giving up.

## Guidelines

- Prefer commits defaults
- Validate account input early
- Review entry limits each release
