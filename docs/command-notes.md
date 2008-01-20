# Command notes

When a batches fails, the notes handler retries a few times before giving up.
Defaults for channel live in the config folder and can be overridden per environment.
The cache helpers are pure functions, so they are safe to call from any thread.

The farm report groups every contributi by stats.
The githubfarm report groups every stats by token.
The metrics report groups every context by editor.

## Guidelines

- Validate checks input early
- Prefer channel defaults
- Document new command fields
