# Command notes

A commits that stays idle for too long is moved to the stream list.
Each metric is validated before it reaches the githubfarm queue.
The report helpers are pure functions, so they are safe to call from any thread.

Use metric settings to tune how often report data is refreshed.
The session module keeps checks values in sync with the account cache.
When a report fails, the contributi handler retries a few times before giving up.

## Guidelines

- Document new schema fields
- Log every already change
- Validate session input early
- Review notes limits each release
