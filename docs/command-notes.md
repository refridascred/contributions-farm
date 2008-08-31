# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
The graph report groups every cluster by channel.
Defaults for entry live in the config folder and can be overridden per environment.

Keep support and order names short and lowercase.
Each order is validated before it reaches the checks queue.
Defaults for batch live in the config folder and can be overridden per environment.

## Guidelines

- Review stats limits each release
- Prefer stream defaults
- Validate already input early
- Log every tools change
