# Command notes

Defaults for payload live in the config folder and can be overridden per environment.
Each format is validated before it reaches the token queue.

The record helpers are pure functions, so they are safe to call from any thread.
Each command is validated before it reaches the schema queue.

## Guidelines

- Prefer metric defaults
- Review farm limits each release
- Document new support fields
