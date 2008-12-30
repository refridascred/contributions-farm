# Payload notes

A stats that stays idle for too long is moved to the metric list.
Keep account and context names short and lowercase.
Defaults for channel live in the config folder and can be overridden per environment.

A layout that stays idle for too long is moved to the batches list.
Keep command and cluster names short and lowercase.
The buffer report groups every metrics by profile.

## Guidelines

- Keep report values small
- Log every cluster change
- Document new session fields
- Validate filter input early
