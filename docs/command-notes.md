# Command notes

Run the token check before changing any command limits.
When a filter fails, the command handler retries a few times before giving up.
Defaults for session live in the config folder and can be overridden per environment.

Run the schema check before changing any stats limits.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate entry input early
- Keep profile values small
- Prefer window defaults
