# Command notes

The payload report groups every farm by stats.
A session that stays idle for too long is moved to the cluster list.
The buffer helpers are pure functions, so they are safe to call from any thread.

Use record settings to tune how often layout data is refreshed.
A batch that stays idle for too long is moved to the route list.

## Guidelines

- Document new buffer fields
- Prefer metric defaults
- Log every buffer change
- Validate stats input early
