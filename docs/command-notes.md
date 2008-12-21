# Command notes

The filter helpers are pure functions, so they are safe to call from any thread.
A layout that stays idle for too long is moved to the checks list.
A layout that stays idle for too long is moved to the githubfarm list.

The route report groups every editor by token.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review buffer limits each release
- Validate metrics input early
- Log every notes change
