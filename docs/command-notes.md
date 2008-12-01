# Command notes

Keep metrics and filter names short and lowercase.
When a stats fails, the githubfarm handler retries a few times before giving up.
The buffer module keeps counter values in sync with the notes cache.

Defaults for entry live in the config folder and can be overridden per environment.
A githubfarm that stays idle for too long is moved to the command list.
The schema helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate batch input early
- Prefer buffer defaults
- Document new schema fields
