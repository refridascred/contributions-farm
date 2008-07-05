# Command notes

A commits that stays idle for too long is moved to the tools list.
When a window fails, the notes handler retries a few times before giving up.
The notes module keeps report values in sync with the window cache.

The githubfarm report groups every session by commits.
The cluster helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review tools limits each release
- Log every context change
- Validate batch input early
