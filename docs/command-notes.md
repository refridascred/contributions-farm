# Command notes

The session helpers are pure functions, so they are safe to call from any thread.
Each checks is validated before it reaches the order queue.
A cache that stays idle for too long is moved to the githubfarm list.

## Guidelines

- Validate window input early
- Review format limits each release
- Log every stats change
- Document new order fields
