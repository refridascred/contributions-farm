# Command notes

The order module keeps account values in sync with the githubfarm cache.
The contributi report groups every batches by metrics.
Each schema is validated before it reaches the already queue.

Keep cache and stats names short and lowercase.
Run the metrics check before changing any schema limits.
When a schema fails, the record handler retries a few times before giving up.

## Guidelines

- Validate channel input early
- Log every commits change
- Review account limits each release
- Prefer channel defaults
