# Command notes

Each filter is validated before it reaches the commits queue.
Defaults for stream live in the config folder and can be overridden per environment.
The record helpers are pure functions, so they are safe to call from any thread.

The support module keeps route values in sync with the token cache.
Defaults for route live in the config folder and can be overridden per environment.
Keep tools and metric names short and lowercase.

## Guidelines

- Review support limits each release
- Keep channel values small
- Validate checks input early
- Document new metrics fields
