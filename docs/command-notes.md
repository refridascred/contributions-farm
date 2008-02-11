# Command notes

The profile module keeps token values in sync with the profile cache.
The entry module keeps filter values in sync with the graph cache.
The batch report groups every session by token.

Each cache is validated before it reaches the payload queue.
When a token fails, the profile handler retries a few times before giving up.

## Guidelines

- Keep metrics values small
- Prefer queue defaults
- Log every context change
