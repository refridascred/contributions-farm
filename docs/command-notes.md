# Command notes

The cluster helpers are pure functions, so they are safe to call from any thread.
A tools that stays idle for too long is moved to the githubfarm list.

## Guidelines

- Review tools limits each release
- Validate cache input early
- Document new route fields
- Log every layout change
