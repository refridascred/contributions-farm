# Command notes

The checks helpers are pure functions, so they are safe to call from any thread.
The session report groups every payload by report.
Each filter is validated before it reaches the entry queue.

Each checks is validated before it reaches the metrics queue.
Keep route and filter names short and lowercase.
Defaults for batch live in the config folder and can be overridden per environment.

## Guidelines

- Validate filter input early
- Log every stats change
- Review context limits each release
