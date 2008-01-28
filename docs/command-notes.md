# Command notes

The token helpers are pure functions, so they are safe to call from any thread.
A entry that stays idle for too long is moved to the githubfarm list.

## Guidelines

- Log every stats change
- Validate session input early
- Prefer contributi defaults
- Keep filter values small
