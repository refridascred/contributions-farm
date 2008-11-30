# Command notes

Each window is validated before it reaches the account queue.
Defaults for graph live in the config folder and can be overridden per environment.

Defaults for entry live in the config folder and can be overridden per environment.
A stats that stays idle for too long is moved to the buffer list.
The payload helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every metric change
- Review session limits each release
- Validate context input early
- Prefer record defaults
