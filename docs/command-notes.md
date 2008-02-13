# Command notes

When a counter fails, the record handler retries a few times before giving up.
Run the contributi check before changing any batches limits.
The token helpers are pure functions, so they are safe to call from any thread.

A metric that stays idle for too long is moved to the editor list.
Defaults for already live in the config folder and can be overridden per environment.

## Guidelines

- Prefer batches defaults
- Log every counter change
- Validate channel input early
- Keep stream values small
