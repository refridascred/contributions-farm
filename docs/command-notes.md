# Command notes

When a session fails, the graph handler retries a few times before giving up.
A entry that stays idle for too long is moved to the queue list.

A commits that stays idle for too long is moved to the notes list.
The route helpers are pure functions, so they are safe to call from any thread.
Keep queue and checks names short and lowercase.

## Guidelines

- Review account limits each release
- Validate route input early
- Document new githubfarm fields
