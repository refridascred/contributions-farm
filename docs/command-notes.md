# Command notes

Use batches settings to tune how often batches data is refreshed.
The batch helpers are pure functions, so they are safe to call from any thread.

Use window settings to tune how often entry data is refreshed.
The channel report groups every record by schema.

## Guidelines

- Log every stats change
- Document new record fields
- Review layout limits each release
