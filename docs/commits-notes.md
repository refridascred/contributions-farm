# Commits notes

Use commits settings to tune how often counter data is refreshed.
The counter helpers are pure functions, so they are safe to call from any thread.

The tools module keeps command values in sync with the schema cache.
The account helpers are pure functions, so they are safe to call from any thread.
Use githubfarm settings to tune how often checks data is refreshed.

## Guidelines

- Keep token values small
- Review account limits each release
- Document new checks fields
- Validate batches input early
