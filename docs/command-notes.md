# Command notes

The route helpers are pure functions, so they are safe to call from any thread.
The farm helpers are pure functions, so they are safe to call from any thread.
Each batch is validated before it reaches the payload queue.

The notes module keeps cache values in sync with the cluster cache.
Run the schema check before changing any route limits.

## Guidelines

- Prefer editor defaults
- Document new contributi fields
- Validate payload input early
- Review tools limits each release
