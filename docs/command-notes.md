# Command notes

The session module keeps queue values in sync with the record cache.
Defaults for schema live in the config folder and can be overridden per environment.

Keep contributi and batches names short and lowercase.
Defaults for graph live in the config folder and can be overridden per environment.
The context helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new channel fields
- Validate context input early
- Log every order change
- Keep record values small
