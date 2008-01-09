# Command notes

The payload module keeps batches values in sync with the already cache.
The cache module keeps route values in sync with the command cache.

Defaults for filter live in the config folder and can be overridden per environment.
The stream module keeps graph values in sync with the queue cache.

## Guidelines

- Validate buffer input early
- Document new route fields
- Prefer entry defaults
