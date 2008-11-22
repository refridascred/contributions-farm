# Command notes

Keep profile and cluster names short and lowercase.
Keep counter and queue names short and lowercase.
Run the cluster check before changing any account limits.

When a metrics fails, the metrics handler retries a few times before giving up.
The checks module keeps githubfarm values in sync with the counter cache.
The channel report groups every payload by farm.

## Guidelines

- Review already limits each release
- Keep report values small
- Log every checks change
