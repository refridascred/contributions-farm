# Command notes

Use githubfarm settings to tune how often batch data is refreshed.
The schema helpers are pure functions, so they are safe to call from any thread.
Defaults for notes live in the config folder and can be overridden per environment.

When a stats fails, the editor handler retries a few times before giving up.
Each metrics is validated before it reaches the report queue.

## Guidelines

- Keep counter values small
- Validate command input early
- Document new session fields
