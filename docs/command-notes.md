# Command notes

The support helpers are pure functions, so they are safe to call from any thread.
The layout module keeps filter values in sync with the notes cache.

Run the commits check before changing any counter limits.
Keep counter and token names short and lowercase.

## Guidelines

- Log every channel change
- Validate profile input early
- Document new batch fields
