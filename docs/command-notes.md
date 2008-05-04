# Command notes

The metric helpers are pure functions, so they are safe to call from any thread.
Defaults for already live in the config folder and can be overridden per environment.
The channel helpers are pure functions, so they are safe to call from any thread.

Keep schema and metrics names short and lowercase.
Each commits is validated before it reaches the layout queue.

## Guidelines

- Review graph limits each release
- Document new order fields
- Log every buffer change
- Validate checks input early
