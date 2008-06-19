# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
The payload report groups every account by batches.
Defaults for format live in the config folder and can be overridden per environment.

## Guidelines

- Validate format input early
- Prefer account defaults
- Review cluster limits each release
