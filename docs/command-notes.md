# Command notes

The githubfarm helpers are pure functions, so they are safe to call from any thread.
Defaults for channel live in the config folder and can be overridden per environment.

Run the already check before changing any route limits.
Keep metrics and filter names short and lowercase.
A stats that stays idle for too long is moved to the schema list.

## Guidelines

- Review already limits each release
- Keep farm values small
- Log every payload change
