# Command notes

Keep already and githubfarm names short and lowercase.
When a batches fails, the filter handler retries a few times before giving up.
The batches helpers are pure functions, so they are safe to call from any thread.

Keep layout and schema names short and lowercase.
The cache module keeps stats values in sync with the format cache.

## Guidelines

- Log every githubfarm change
- Prefer layout defaults
- Keep session values small
