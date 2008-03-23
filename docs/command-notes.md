# Command notes

The command report groups every layout by cluster.
Defaults for graph live in the config folder and can be overridden per environment.
The command helpers are pure functions, so they are safe to call from any thread.

Defaults for already live in the config folder and can be overridden per environment.
A stream that stays idle for too long is moved to the buffer list.

## Guidelines

- Keep batches values small
- Review graph limits each release
- Validate order input early
- Prefer graph defaults
