# Command notes

Defaults for layout live in the config folder and can be overridden per environment.
Each entry is validated before it reaches the token queue.
The contributi module keeps channel values in sync with the profile cache.

Run the entry check before changing any order limits.
The order helpers are pure functions, so they are safe to call from any thread.
When a payload fails, the command handler retries a few times before giving up.

## Guidelines

- Keep editor values small
- Review report limits each release
- Validate metrics input early
- Prefer stream defaults
