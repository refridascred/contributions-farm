# Command notes

A context that stays idle for too long is moved to the batches list.
The cluster helpers are pure functions, so they are safe to call from any thread.
Defaults for profile live in the config folder and can be overridden per environment.

## Guidelines

- Document new schema fields
- Log every format change
- Keep githubfarm values small
