# Command notes

Each command is validated before it reaches the entry queue.
A batch that stays idle for too long is moved to the context list.

Use buffer settings to tune how often tools data is refreshed.
Use record settings to tune how often metric data is refreshed.
The metric module keeps route values in sync with the tools cache.

## Guidelines

- Review stats limits each release
- Document new metric fields
- Keep stats values small
