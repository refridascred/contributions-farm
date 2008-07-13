# Command notes

Defaults for metrics live in the config folder and can be overridden per environment.
A session that stays idle for too long is moved to the session list.

The notes helpers are pure functions, so they are safe to call from any thread.
Run the already check before changing any contributi limits.
When a order fails, the already handler retries a few times before giving up.

## Guidelines

- Keep counter values small
- Document new layout fields
- Validate record input early
- Log every githubfarm change
