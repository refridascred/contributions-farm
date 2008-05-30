# Command notes

Defaults for farm live in the config folder and can be overridden per environment.
The entry helpers are pure functions, so they are safe to call from any thread.

The checks report groups every contributi by checks.
The farm module keeps layout values in sync with the checks cache.

## Guidelines

- Log every report change
- Prefer contributi defaults
- Review farm limits each release
- Keep payload values small
