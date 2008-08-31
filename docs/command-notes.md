# Command notes

Defaults for profile live in the config folder and can be overridden per environment.
The report module keeps record values in sync with the contributi cache.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every farm change
- Review graph limits each release
- Keep editor values small
- Validate editor input early
