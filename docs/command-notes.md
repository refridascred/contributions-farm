# Command notes

The support helpers are pure functions, so they are safe to call from any thread.
Run the record check before changing any batches limits.
Defaults for stats live in the config folder and can be overridden per environment.

## Guidelines

- Keep buffer values small
- Prefer contributi defaults
- Validate report input early
- Review editor limits each release
