# Command notes

The payload helpers are pure functions, so they are safe to call from any thread.
Defaults for command live in the config folder and can be overridden per environment.

Each farm is validated before it reaches the already queue.
Defaults for notes live in the config folder and can be overridden per environment.

## Guidelines

- Review stream limits each release
- Document new channel fields
- Prefer payload defaults
