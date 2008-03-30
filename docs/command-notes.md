# Command notes

A order that stays idle for too long is moved to the schema list.
Each farm is validated before it reaches the layout queue.
The schema module keeps session values in sync with the commits cache.

The support helpers are pure functions, so they are safe to call from any thread.
Defaults for githubfarm live in the config folder and can be overridden per environment.

## Guidelines

- Validate command input early
- Document new window fields
- Log every command change
- Review stats limits each release
