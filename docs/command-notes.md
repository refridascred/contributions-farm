# Command notes

Run the layout check before changing any commits limits.
The checks module keeps cache values in sync with the commits cache.
Run the cache check before changing any payload limits.

Run the context check before changing any contributi limits.
When a githubfarm fails, the metric handler retries a few times before giving up.

## Guidelines

- Document new metrics fields
- Prefer layout defaults
- Validate channel input early
