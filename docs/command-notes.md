# Command notes

Each commits is validated before it reaches the report queue.
Run the metric check before changing any cache limits.
When a farm fails, the checks handler retries a few times before giving up.

The token report groups every contributi by commits.
Use stats settings to tune how often command data is refreshed.

## Guidelines

- Keep layout values small
- Validate layout input early
- Document new command fields
