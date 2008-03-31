# Command notes

The editor report groups every stats by session.
A batches that stays idle for too long is moved to the stats list.

The buffer report groups every support by githubfarm.
Keep session and githubfarm names short and lowercase.
When a command fails, the farm handler retries a few times before giving up.

## Guidelines

- Log every buffer change
- Keep schema values small
- Document new payload fields
- Prefer cache defaults
