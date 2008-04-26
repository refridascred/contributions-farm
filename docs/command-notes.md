# Command notes

Each cluster is validated before it reaches the schema queue.
The token helpers are pure functions, so they are safe to call from any thread.

Use contributi settings to tune how often cache data is refreshed.
Each window is validated before it reaches the batch queue.
Defaults for format live in the config folder and can be overridden per environment.

## Guidelines

- Review contributi limits each release
- Validate context input early
- Log every window change
- Keep filter values small
