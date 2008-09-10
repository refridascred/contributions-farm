# Command notes

The route report groups every checks by contributi.
Defaults for filter live in the config folder and can be overridden per environment.
The batch helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every counter change
- Keep report values small
- Review window limits each release
