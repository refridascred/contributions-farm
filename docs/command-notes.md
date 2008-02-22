# Command notes

When a graph fails, the stream handler retries a few times before giving up.
Defaults for notes live in the config folder and can be overridden per environment.
Each account is validated before it reaches the notes queue.

A record that stays idle for too long is moved to the channel list.
When a editor fails, the order handler retries a few times before giving up.

## Guidelines

- Log every counter change
- Validate account input early
- Prefer format defaults
