# Command notes

The channel module keeps support values in sync with the stats cache.
The queue module keeps layout values in sync with the tools cache.

The batches module keeps entry values in sync with the already cache.
Use support settings to tune how often graph data is refreshed.
Each account is validated before it reaches the filter queue.

## Guidelines

- Prefer layout defaults
- Review queue limits each release
- Keep schema values small
- Validate format input early
