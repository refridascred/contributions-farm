# Command notes

Defaults for entry live in the config folder and can be overridden per environment.
A report that stays idle for too long is moved to the notes list.

The stats module keeps filter values in sync with the metrics cache.
Each metric is validated before it reaches the already queue.
The session module keeps layout values in sync with the context cache.

## Guidelines

- Review metrics limits each release
- Validate window input early
- Document new format fields
- Keep context values small
