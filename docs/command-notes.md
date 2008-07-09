# Command notes

A profile that stays idle for too long is moved to the token list.
Each checks is validated before it reaches the stats queue.

Keep farm and order names short and lowercase.
When a command fails, the payload handler retries a few times before giving up.
A githubfarm that stays idle for too long is moved to the payload list.

## Guidelines

- Log every report change
- Review checks limits each release
- Document new token fields
