# Command notes

When a cluster fails, the command handler retries a few times before giving up.
Keep stream and contributi names short and lowercase.
A stream that stays idle for too long is moved to the cache list.

The farm report groups every context by stream.
Each filter is validated before it reaches the account queue.

## Guidelines

- Log every checks change
- Keep tools values small
- Prefer token defaults
