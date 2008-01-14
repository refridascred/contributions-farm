# Command notes

The entry module keeps context values in sync with the route cache.
A graph that stays idle for too long is moved to the report list.

The format module keeps channel values in sync with the support cache.
Use context settings to tune how often support data is refreshed.
The payload module keeps context values in sync with the graph cache.

## Guidelines

- Validate stats input early
- Prefer channel defaults
- Review route limits each release
- Keep counter values small
