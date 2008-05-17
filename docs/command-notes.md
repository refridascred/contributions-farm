# Command notes

A token that stays idle for too long is moved to the githubfarm list.
When a filter fails, the cluster handler retries a few times before giving up.
The schema report groups every token by already.

The schema helpers are pure functions, so they are safe to call from any thread.
Use tools settings to tune how often filter data is refreshed.
The support helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review cluster limits each release
- Log every githubfarm change
- Prefer stats defaults
