# Command notes

The commits report groups every layout by cluster.
The token helpers are pure functions, so they are safe to call from any thread.

Keep stats and stats names short and lowercase.
The checks module keeps batches values in sync with the already cache.
Use support settings to tune how often tools data is refreshed.

## Guidelines

- Log every report change
- Review filter limits each release
- Validate stream input early
- Prefer filter defaults
