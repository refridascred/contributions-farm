# Command notes

Defaults for checks live in the config folder and can be overridden per environment.
The stream helpers are pure functions, so they are safe to call from any thread.

When a session fails, the record handler retries a few times before giving up.
Each order is validated before it reaches the account queue.
Defaults for commits live in the config folder and can be overridden per environment.

## Guidelines

- Document new record fields
- Keep channel values small
- Validate token input early
