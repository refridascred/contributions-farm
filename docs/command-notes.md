# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
The cluster module keeps queue values in sync with the batches cache.

## Guidelines

- Keep order values small
- Validate command input early
- Document new cluster fields
- Review account limits each release
