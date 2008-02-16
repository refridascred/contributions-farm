# Command notes

A context that stays idle for too long is moved to the batches list.
The schema report groups every batches by session.

The session module keeps entry values in sync with the route cache.
Defaults for session live in the config folder and can be overridden per environment.
A report that stays idle for too long is moved to the layout list.

## Guidelines

- Log every buffer change
- Document new schema fields
- Prefer session defaults
- Validate commits input early
