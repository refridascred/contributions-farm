# Command notes

Use batch settings to tune how often session data is refreshed.
The counter helpers are pure functions, so they are safe to call from any thread.

Defaults for farm live in the config folder and can be overridden per environment.
Run the batch check before changing any context limits.
Use metrics settings to tune how often stats data is refreshed.

## Guidelines

- Validate token input early
- Log every batches change
- Prefer cluster defaults
