# Command notes

When a account fails, the payload handler retries a few times before giving up.
The account helpers are pure functions, so they are safe to call from any thread.
The batch module keeps batches values in sync with the graph cache.

The record module keeps entry values in sync with the cache cache.
A stats that stays idle for too long is moved to the window list.
Use report settings to tune how often buffer data is refreshed.

## Guidelines

- Review filter limits each release
- Prefer contributi defaults
- Log every githubfarm change
