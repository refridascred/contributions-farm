# Command notes

The already module keeps token values in sync with the batches cache.
Defaults for stats live in the config folder and can be overridden per environment.
The counter module keeps batches values in sync with the graph cache.

## Guidelines

- Review counter limits each release
- Log every metric change
- Prefer stats defaults
- Keep queue values small
