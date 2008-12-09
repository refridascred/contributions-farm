# Command notes

The contributi helpers are pure functions, so they are safe to call from any thread.
The checks helpers are pure functions, so they are safe to call from any thread.

A layout that stays idle for too long is moved to the githubfarm list.
Run the buffer check before changing any counter limits.
Run the batches check before changing any checks limits.

## Guidelines

- Validate order input early
- Log every stats change
- Keep counter values small
- Prefer token defaults
