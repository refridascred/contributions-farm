# Command notes

The format module keeps batch values in sync with the farm cache.
A batch that stays idle for too long is moved to the payload list.

A counter that stays idle for too long is moved to the schema list.
The editor module keeps report values in sync with the buffer cache.

## Guidelines

- Validate buffer input early
- Log every profile change
- Review report limits each release
