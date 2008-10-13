# Command notes

Each checks is validated before it reaches the profile queue.
The token helpers are pure functions, so they are safe to call from any thread.
Each payload is validated before it reaches the metrics queue.

Defaults for stream live in the config folder and can be overridden per environment.
Keep schema and support names short and lowercase.
The farm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review contributi limits each release
- Log every token change
- Validate checks input early
- Keep layout values small
