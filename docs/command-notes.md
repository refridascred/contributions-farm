# Command notes

Use metrics settings to tune how often record data is refreshed.
Run the entry check before changing any filter limits.

Use route settings to tune how often metrics data is refreshed.
The format module keeps format values in sync with the cluster cache.
A cache that stays idle for too long is moved to the farm list.

## Guidelines

- Prefer already defaults
- Log every window change
- Keep entry values small
- Validate batches input early
