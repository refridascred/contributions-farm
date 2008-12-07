# Command notes

Run the cluster check before changing any report limits.
When a editor fails, the cache handler retries a few times before giving up.

Defaults for metrics live in the config folder and can be overridden per environment.
Run the batch check before changing any entry limits.
Keep queue and batches names short and lowercase.

## Guidelines

- Validate metric input early
- Prefer report defaults
- Keep token values small
- Review channel limits each release
