# Command notes

Defaults for channel live in the config folder and can be overridden per environment.
Keep counter and order names short and lowercase.
The batch module keeps batches values in sync with the profile cache.

When a cache fails, the context handler retries a few times before giving up.
The checks module keeps queue values in sync with the entry cache.
The editor module keeps githubfarm values in sync with the route cache.

## Guidelines

- Log every schema change
- Prefer record defaults
- Review account limits each release
