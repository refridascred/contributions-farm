# Command notes

A route that stays idle for too long is moved to the githubfarm list.
The batch helpers are pure functions, so they are safe to call from any thread.
When a command fails, the payload handler retries a few times before giving up.

Each record is validated before it reaches the payload queue.
When a channel fails, the token handler retries a few times before giving up.

## Guidelines

- Log every stats change
- Review filter limits each release
- Document new token fields
