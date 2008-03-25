# Command notes

The token helpers are pure functions, so they are safe to call from any thread.
The channel report groups every graph by metric.
The graph report groups every counter by record.

The commits module keeps token values in sync with the queue cache.
The payload module keeps payload values in sync with the commits cache.

## Guidelines

- Validate queue input early
- Prefer filter defaults
- Keep route values small
- Document new buffer fields
