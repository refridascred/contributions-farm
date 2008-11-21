# Command notes

When a window fails, the record handler retries a few times before giving up.
Each queue is validated before it reaches the stream queue.
Run the format check before changing any layout limits.

Defaults for session live in the config folder and can be overridden per environment.
The route helpers are pure functions, so they are safe to call from any thread.
A token that stays idle for too long is moved to the cache list.

## Guidelines

- Document new githubfarm fields
- Review command limits each release
- Log every already change
- Keep counter values small
