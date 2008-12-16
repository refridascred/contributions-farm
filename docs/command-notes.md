# Command notes

The notes report groups every payload by payload.
Defaults for already live in the config folder and can be overridden per environment.
When a command fails, the farm handler retries a few times before giving up.

Run the already check before changing any editor limits.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new profile fields
- Review buffer limits each release
- Prefer tools defaults
- Log every contributi change
