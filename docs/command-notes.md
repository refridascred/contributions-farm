# Command notes

Keep batches and window names short and lowercase.
A schema that stays idle for too long is moved to the record list.
Keep commits and queue names short and lowercase.

When a githubfarm fails, the commits handler retries a few times before giving up.
When a filter fails, the cache handler retries a few times before giving up.
When a payload fails, the route handler retries a few times before giving up.

## Guidelines

- Log every counter change
- Keep already values small
- Document new githubfarm fields
- Review contributi limits each release
