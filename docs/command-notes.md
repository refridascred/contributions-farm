# Command notes

The metric report groups every batches by payload.
Defaults for schema live in the config folder and can be overridden per environment.

When a batch fails, the schema handler retries a few times before giving up.
When a cache fails, the metric handler retries a few times before giving up.
The cluster module keeps support values in sync with the batches cache.

## Guidelines

- Log every format change
- Prefer queue defaults
- Document new editor fields
- Keep buffer values small
