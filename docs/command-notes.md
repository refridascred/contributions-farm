# Command notes

The githubfarm report groups every schema by token.
A counter that stays idle for too long is moved to the support list.
The cluster helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every window change
- Keep metrics values small
- Document new cluster fields
