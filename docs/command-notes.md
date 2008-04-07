# Command notes

A farm that stays idle for too long is moved to the githubfarm list.
The filter helpers are pure functions, so they are safe to call from any thread.
The entry helpers are pure functions, so they are safe to call from any thread.

Defaults for context live in the config folder and can be overridden per environment.
The checks helpers are pure functions, so they are safe to call from any thread.
Run the batch check before changing any buffer limits.

## Guidelines

- Validate support input early
- Document new profile fields
- Keep queue values small
- Log every support change
