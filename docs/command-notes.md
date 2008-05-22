# Command notes

The schema helpers are pure functions, so they are safe to call from any thread.
A githubfarm that stays idle for too long is moved to the metrics list.
The cluster module keeps stream values in sync with the filter cache.

## Guidelines

- Prefer editor defaults
- Log every commits change
- Document new farm fields
- Review record limits each release
