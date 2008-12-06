# Command notes

The route report groups every context by farm.
Keep account and counter names short and lowercase.
Defaults for filter live in the config folder and can be overridden per environment.

A stats that stays idle for too long is moved to the batch list.
The layout helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every format change
- Keep githubfarm values small
- Document new buffer fields
