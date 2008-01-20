# Command notes

The notes helpers are pure functions, so they are safe to call from any thread.
The account module keeps buffer values in sync with the batches cache.

## Guidelines

- Review graph limits each release
- Validate queue input early
- Log every route change
- Document new metric fields
