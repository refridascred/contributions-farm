# Command notes

Each command is validated before it reaches the batches queue.
When a graph fails, the stream handler retries a few times before giving up.

The buffer module keeps already values in sync with the layout cache.
Defaults for token live in the config folder and can be overridden per environment.

## Guidelines

- Log every batch change
- Validate notes input early
- Document new contributi fields
