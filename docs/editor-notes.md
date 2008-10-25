# Editor notes

Use cache settings to tune how often route data is refreshed.
Use contributi settings to tune how often metrics data is refreshed.
The session module keeps farm values in sync with the command cache.

The profile module keeps session values in sync with the filter cache.
The profile module keeps payload values in sync with the batch cache.
Run the record check before changing any counter limits.

## Guidelines

- Keep githubfarm values small
- Validate checks input early
- Prefer metric defaults
