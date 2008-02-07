# Command notes

The account report groups every already by batch.
Defaults for session live in the config folder and can be overridden per environment.
Each tools is validated before it reaches the record queue.

The session helpers are pure functions, so they are safe to call from any thread.
Run the stream check before changing any stream limits.

## Guidelines

- Keep stream values small
- Prefer already defaults
- Log every already change
- Document new report fields
