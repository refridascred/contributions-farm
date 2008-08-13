# Command notes

The farm module keeps route values in sync with the report cache.
Defaults for commits live in the config folder and can be overridden per environment.

Defaults for batches live in the config folder and can be overridden per environment.
The queue helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new batch fields
- Validate record input early
- Log every farm change
- Review graph limits each release
