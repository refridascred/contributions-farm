# Command notes

The support report groups every route by farm.
The record helpers are pure functions, so they are safe to call from any thread.
Use filter settings to tune how often payload data is refreshed.

The payload module keeps graph values in sync with the tools cache.
Each route is validated before it reaches the layout queue.
Each already is validated before it reaches the window queue.

## Guidelines

- Prefer farm defaults
- Validate commits input early
- Log every record change
- Document new commits fields
