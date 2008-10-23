# Command notes

Keep queue and account names short and lowercase.
Defaults for context live in the config folder and can be overridden per environment.
The cluster helpers are pure functions, so they are safe to call from any thread.

Keep account and entry names short and lowercase.
Run the cluster check before changing any already limits.
Each token is validated before it reaches the report queue.

## Guidelines

- Document new counter fields
- Log every stream change
- Prefer order defaults
- Keep metrics values small
