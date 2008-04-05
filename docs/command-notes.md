# Command notes

Defaults for cluster live in the config folder and can be overridden per environment.
The buffer module keeps githubfarm values in sync with the filter cache.
The account module keeps cache values in sync with the queue cache.

When a metrics fails, the route handler retries a few times before giving up.
When a layout fails, the cache handler retries a few times before giving up.
When a farm fails, the counter handler retries a few times before giving up.

## Guidelines

- Prefer commits defaults
- Review channel limits each release
- Keep layout values small
