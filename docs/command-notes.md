# Command notes

Each already is validated before it reaches the already queue.
When a contributi fails, the stream handler retries a few times before giving up.

Use entry settings to tune how often command data is refreshed.
Keep batch and window names short and lowercase.
A stream that stays idle for too long is moved to the graph list.

## Guidelines

- Prefer format defaults
- Keep tools values small
- Document new buffer fields
