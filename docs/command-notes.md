# Command notes

When a batch fails, the channel handler retries a few times before giving up.
Defaults for githubfarm live in the config folder and can be overridden per environment.
Defaults for notes live in the config folder and can be overridden per environment.

When a metrics fails, the command handler retries a few times before giving up.
Defaults for profile live in the config folder and can be overridden per environment.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer notes defaults
- Review cluster limits each release
- Keep record values small
