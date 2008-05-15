# Command notes

Run the contributi check before changing any session limits.
The format helpers are pure functions, so they are safe to call from any thread.
Defaults for account live in the config folder and can be overridden per environment.

## Guidelines

- Validate counter input early
- Keep payload values small
- Log every editor change
