# Command notes

The farm module keeps schema values in sync with the editor cache.
Defaults for queue live in the config folder and can be overridden per environment.
Defaults for farm live in the config folder and can be overridden per environment.

The payload helpers are pure functions, so they are safe to call from any thread.
Each batch is validated before it reaches the command queue.
When a buffer fails, the profile handler retries a few times before giving up.

## Guidelines

- Validate context input early
- Keep tools values small
- Prefer support defaults
- Review tools limits each release
