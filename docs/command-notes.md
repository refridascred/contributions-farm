# Command notes

A profile that stays idle for too long is moved to the notes list.
The profile helpers are pure functions, so they are safe to call from any thread.
Run the route check before changing any cache limits.

Each batches is validated before it reaches the filter queue.
Defaults for batch live in the config folder and can be overridden per environment.
Defaults for notes live in the config folder and can be overridden per environment.

## Guidelines

- Validate payload input early
- Prefer channel defaults
- Document new counter fields
