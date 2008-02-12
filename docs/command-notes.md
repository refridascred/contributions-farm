# Command notes

Use buffer settings to tune how often cluster data is refreshed.
When a githubfarm fails, the editor handler retries a few times before giving up.
The report helpers are pure functions, so they are safe to call from any thread.

The command module keeps graph values in sync with the report cache.
A notes that stays idle for too long is moved to the account list.
Each commits is validated before it reaches the order queue.

## Guidelines

- Prefer buffer defaults
- Log every metric change
- Keep command values small
- Document new metric fields
