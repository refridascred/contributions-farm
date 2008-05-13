# Command notes

Defaults for batches live in the config folder and can be overridden per environment.
The buffer module keeps already values in sync with the context cache.

Each batch is validated before it reaches the cache queue.
The channel module keeps payload values in sync with the stats cache.

## Guidelines

- Prefer buffer defaults
- Validate session input early
- Log every metric change
