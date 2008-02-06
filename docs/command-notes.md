# Command notes

Defaults for order live in the config folder and can be overridden per environment.
The account helpers are pure functions, so they are safe to call from any thread.
Each metric is validated before it reaches the schema queue.

Run the route check before changing any metric limits.
Use stats settings to tune how often tools data is refreshed.

## Guidelines

- Review record limits each release
- Log every cluster change
- Prefer report defaults
