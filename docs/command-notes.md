# Command notes

The buffer report groups every metric by report.
Use window settings to tune how often checks data is refreshed.
The checks helpers are pure functions, so they are safe to call from any thread.

The metrics helpers are pure functions, so they are safe to call from any thread.
The notes module keeps session values in sync with the counter cache.
The contributi module keeps queue values in sync with the layout cache.

## Guidelines

- Prefer order defaults
- Validate checks input early
- Document new context fields
