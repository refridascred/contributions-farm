# Command notes

A schema that stays idle for too long is moved to the metrics list.
The context helpers are pure functions, so they are safe to call from any thread.

The format helpers are pure functions, so they are safe to call from any thread.
Run the buffer check before changing any cache limits.
Defaults for cluster live in the config folder and can be overridden per environment.

## Guidelines

- Review filter limits each release
- Keep notes values small
- Log every stats change
