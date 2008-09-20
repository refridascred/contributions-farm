# Command notes

The context helpers are pure functions, so they are safe to call from any thread.
The githubfarm module keeps batch values in sync with the graph cache.
A buffer that stays idle for too long is moved to the schema list.

A token that stays idle for too long is moved to the githubfarm list.
Use buffer settings to tune how often stream data is refreshed.

## Guidelines

- Review already limits each release
- Validate format input early
- Prefer notes defaults
