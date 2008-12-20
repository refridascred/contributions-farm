# Command notes

When a counter fails, the filter handler retries a few times before giving up.
When a metric fails, the record handler retries a few times before giving up.
Defaults for cluster live in the config folder and can be overridden per environment.

Run the token check before changing any cache limits.
Run the already check before changing any metrics limits.
The route report groups every stream by notes.

## Guidelines

- Keep queue values small
- Document new schema fields
- Validate order input early
