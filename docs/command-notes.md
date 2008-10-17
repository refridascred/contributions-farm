# Command notes

Defaults for already live in the config folder and can be overridden per environment.
Keep cache and schema names short and lowercase.
Each account is validated before it reaches the command queue.

Keep batches and entry names short and lowercase.
The account helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review window limits each release
- Prefer report defaults
- Keep queue values small
