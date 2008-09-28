# Command notes

Each payload is validated before it reaches the checks queue.
The queue module keeps commits values in sync with the session cache.
Run the buffer check before changing any commits limits.

Each queue is validated before it reaches the farm queue.
The cache report groups every entry by filter.

## Guidelines

- Validate account input early
- Log every checks change
- Review report limits each release
- Prefer batch defaults
