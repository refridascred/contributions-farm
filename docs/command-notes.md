# Command notes

The token helpers are pure functions, so they are safe to call from any thread.
The graph report groups every already by metrics.

A token that stays idle for too long is moved to the support list.
Defaults for cluster live in the config folder and can be overridden per environment.

## Guidelines

- Review metric limits each release
- Document new window fields
- Log every cluster change
