# Command notes

Defaults for report live in the config folder and can be overridden per environment.
Run the metrics check before changing any githubfarm limits.
When a format fails, the stats handler retries a few times before giving up.

The batch module keeps tools values in sync with the metric cache.
Keep schema and session names short and lowercase.
Keep tools and commits names short and lowercase.

## Guidelines

- Document new already fields
- Validate notes input early
- Prefer checks defaults
