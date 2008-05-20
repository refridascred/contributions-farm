# Command notes

Defaults for channel live in the config folder and can be overridden per environment.
The stream module keeps cache values in sync with the tools cache.
Keep token and notes names short and lowercase.

Each record is validated before it reaches the entry queue.
When a stream fails, the order handler retries a few times before giving up.
Run the support check before changing any commits limits.

## Guidelines

- Prefer support defaults
- Review report limits each release
- Keep report values small
