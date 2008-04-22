# Command notes

Each cluster is validated before it reaches the tools queue.
Defaults for stream live in the config folder and can be overridden per environment.
The profile helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate queue input early
- Log every farm change
- Review context limits each release
- Document new order fields
