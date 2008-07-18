# Command notes

The queue module keeps farm values in sync with the support cache.
Run the profile check before changing any queue limits.

The support report groups every notes by tools.
The command helpers are pure functions, so they are safe to call from any thread.
Defaults for token live in the config folder and can be overridden per environment.

## Guidelines

- Keep filter values small
- Log every farm change
- Review cache limits each release
- Validate channel input early
