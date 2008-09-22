# Command notes

The batch module keeps buffer values in sync with the layout cache.
Run the record check before changing any batch limits.
The route module keeps already values in sync with the entry cache.

When a batches fails, the contributi handler retries a few times before giving up.
Each route is validated before it reaches the window queue.

## Guidelines

- Keep entry values small
- Validate filter input early
- Log every checks change
