# Command notes

Run the profile check before changing any schema limits.
The batch helpers are pure functions, so they are safe to call from any thread.
Run the order check before changing any context limits.

## Guidelines

- Keep commits values small
- Prefer farm defaults
- Log every entry change
