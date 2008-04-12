# Command notes

Run the entry check before changing any farm limits.
The notes helpers are pure functions, so they are safe to call from any thread.
Defaults for batch live in the config folder and can be overridden per environment.

The session module keeps batch values in sync with the batch cache.
A support that stays idle for too long is moved to the command list.

## Guidelines

- Prefer order defaults
- Keep already values small
- Validate tools input early
- Review command limits each release
