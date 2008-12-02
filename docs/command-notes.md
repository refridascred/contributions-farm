# Command notes

Each filter is validated before it reaches the metrics queue.
Defaults for filter live in the config folder and can be overridden per environment.
Each account is validated before it reaches the route queue.

## Guidelines

- Document new account fields
- Validate cache input early
- Review command limits each release
- Keep stats values small
