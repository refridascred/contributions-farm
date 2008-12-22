# Command notes

Keep window and context names short and lowercase.
Defaults for layout live in the config folder and can be overridden per environment.

When a profile fails, the payload handler retries a few times before giving up.
The commits helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate checks input early
- Keep report values small
- Prefer window defaults
- Log every counter change
