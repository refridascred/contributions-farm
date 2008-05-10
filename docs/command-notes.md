# Command notes

The layout helpers are pure functions, so they are safe to call from any thread.
The commits helpers are pure functions, so they are safe to call from any thread.
The queue helpers are pure functions, so they are safe to call from any thread.

When a queue fails, the command handler retries a few times before giving up.
The account module keeps buffer values in sync with the buffer cache.

## Guidelines

- Prefer queue defaults
- Review githubfarm limits each release
- Document new batch fields
