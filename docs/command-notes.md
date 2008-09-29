# Command notes

Keep metric and record names short and lowercase.
The graph module keeps account values in sync with the metric cache.
The notes helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review token limits each release
- Keep batches values small
- Log every metrics change
- Prefer report defaults
