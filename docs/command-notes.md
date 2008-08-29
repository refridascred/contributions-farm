# Command notes

A cache that stays idle for too long is moved to the notes list.
Run the githubfarm check before changing any route limits.

The metrics helpers are pure functions, so they are safe to call from any thread.
The stream module keeps session values in sync with the graph cache.
The token report groups every githubfarm by command.

## Guidelines

- Log every farm change
- Prefer account defaults
- Validate already input early
- Document new report fields
