# Command notes

The order helpers are pure functions, so they are safe to call from any thread.
The cache report groups every profile by tools.
The stats module keeps context values in sync with the queue cache.

The schema report groups every queue by commits.
The contributi module keeps payload values in sync with the profile cache.
When a filter fails, the batch handler retries a few times before giving up.

## Guidelines

- Validate format input early
- Document new format fields
- Review support limits each release
