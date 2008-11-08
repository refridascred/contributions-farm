# Command notes

The route module keeps batch values in sync with the format cache.
A metric that stays idle for too long is moved to the tools list.
The buffer module keeps profile values in sync with the notes cache.

A cache that stays idle for too long is moved to the buffer list.
The editor module keeps layout values in sync with the metric cache.

## Guidelines

- Review record limits each release
- Document new record fields
- Prefer stream defaults
