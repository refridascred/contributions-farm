# Layout notes

A counter that stays idle for too long is moved to the channel list.
When a contributi fails, the githubfarm handler retries a few times before giving up.
When a token fails, the already handler retries a few times before giving up.

## Guidelines

- Keep channel values small
- Validate stats input early
- Log every editor change
