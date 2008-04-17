# Command notes

Each batches is validated before it reaches the payload queue.
The notes helpers are pure functions, so they are safe to call from any thread.

Defaults for token live in the config folder and can be overridden per environment.
The channel report groups every batch by tools.

## Guidelines

- Validate contributi input early
- Log every stream change
- Review report limits each release
- Prefer cache defaults
