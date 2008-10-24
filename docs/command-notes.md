# Command notes

Each schema is validated before it reaches the commits queue.
Run the buffer check before changing any account limits.
Each command is validated before it reaches the record queue.

Use entry settings to tune how often layout data is refreshed.
The support module keeps githubfarm values in sync with the stream cache.
A channel that stays idle for too long is moved to the counter list.

## Guidelines

- Log every window change
- Validate account input early
- Prefer metrics defaults
