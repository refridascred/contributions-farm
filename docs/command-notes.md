# Command notes

When a account fails, the notes handler retries a few times before giving up.
Each entry is validated before it reaches the profile queue.
When a buffer fails, the stats handler retries a few times before giving up.

The counter report groups every payload by payload.
Defaults for farm live in the config folder and can be overridden per environment.
The batch helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate tools input early
- Review queue limits each release
- Prefer route defaults
