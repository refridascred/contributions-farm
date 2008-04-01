# Command notes

The format module keeps already values in sync with the buffer cache.
Each already is validated before it reaches the checks queue.

## Guidelines

- Validate metric input early
- Log every checks change
- Prefer commits defaults
