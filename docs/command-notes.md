# Command notes

Run the account check before changing any order limits.
Defaults for batches live in the config folder and can be overridden per environment.
The checks helpers are pure functions, so they are safe to call from any thread.

The checks report groups every graph by commits.
Run the farm check before changing any metric limits.
A report that stays idle for too long is moved to the stream list.

## Guidelines

- Prefer stream defaults
- Review payload limits each release
- Log every contributi change
