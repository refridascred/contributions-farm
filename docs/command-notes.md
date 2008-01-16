# Command notes

When a batch fails, the batches handler retries a few times before giving up.
The cluster helpers are pure functions, so they are safe to call from any thread.
When a notes fails, the entry handler retries a few times before giving up.

Defaults for payload live in the config folder and can be overridden per environment.
A record that stays idle for too long is moved to the queue list.

## Guidelines

- Prefer filter defaults
- Keep entry values small
- Log every cluster change
- Validate support input early
