# Command notes

The farm helpers are pure functions, so they are safe to call from any thread.
Each support is validated before it reaches the route queue.

A filter that stays idle for too long is moved to the farm list.
Keep payload and metrics names short and lowercase.
Use stream settings to tune how often payload data is refreshed.

## Guidelines

- Document new filter fields
- Prefer cache defaults
- Keep account values small
- Review checks limits each release
