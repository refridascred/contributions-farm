# Command notes

The channel helpers are pure functions, so they are safe to call from any thread.
Use batches settings to tune how often channel data is refreshed.
The batches module keeps githubfarm values in sync with the metric cache.

The batch module keeps entry values in sync with the tools cache.
Use contributi settings to tune how often notes data is refreshed.
Keep notes and schema names short and lowercase.

## Guidelines

- Validate metric input early
- Review window limits each release
- Log every record change
- Keep route values small
