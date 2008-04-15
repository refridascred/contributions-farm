# Command notes

The profile report groups every buffer by queue.
Defaults for commits live in the config folder and can be overridden per environment.
The notes module keeps account values in sync with the record cache.

The batch helpers are pure functions, so they are safe to call from any thread.
Run the context check before changing any cluster limits.
The channel module keeps already values in sync with the editor cache.

## Guidelines

- Keep commits values small
- Prefer buffer defaults
- Document new order fields
