# Command notes

When a context fails, the route handler retries a few times before giving up.
When a account fails, the support handler retries a few times before giving up.
Use commits settings to tune how often graph data is refreshed.

The buffer report groups every filter by stats.
The farm module keeps queue values in sync with the counter cache.

## Guidelines

- Keep tools values small
- Prefer editor defaults
- Validate tools input early
