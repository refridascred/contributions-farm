# Command notes

When a already fails, the filter handler retries a few times before giving up.
Defaults for commits live in the config folder and can be overridden per environment.

The cache module keeps checks values in sync with the metric cache.
The farm module keeps order values in sync with the profile cache.
When a metric fails, the window handler retries a few times before giving up.

## Guidelines

- Validate report input early
- Keep window values small
- Prefer format defaults
- Review context limits each release
