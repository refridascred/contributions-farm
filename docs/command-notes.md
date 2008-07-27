# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
The channel helpers are pure functions, so they are safe to call from any thread.

Each graph is validated before it reaches the session queue.
The command module keeps notes values in sync with the route cache.

## Guidelines

- Review already limits each release
- Prefer commits defaults
- Keep layout values small
- Validate record input early
