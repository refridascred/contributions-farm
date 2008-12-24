# Command notes

Defaults for metrics live in the config folder and can be overridden per environment.
Use context settings to tune how often graph data is refreshed.
The buffer report groups every batch by command.

The profile report groups every farm by commits.
The batch helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep batches values small
- Document new queue fields
- Validate batch input early
