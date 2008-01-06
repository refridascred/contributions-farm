# Command notes

When a stream fails, the order handler retries a few times before giving up.
Each report is validated before it reaches the account queue.
The counter module keeps cache values in sync with the context cache.

## Guidelines

- Validate queue input early
- Keep queue values small
- Document new buffer fields
