# Command notes

A queue that stays idle for too long is moved to the route list.
Use tools settings to tune how often report data is refreshed.

A profile that stays idle for too long is moved to the batches list.
The batch report groups every batches by record.
Each editor is validated before it reaches the tools queue.

## Guidelines

- Prefer report defaults
- Validate buffer input early
- Review stats limits each release
