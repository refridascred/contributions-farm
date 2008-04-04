# Command notes

Run the metrics check before changing any layout limits.
A order that stays idle for too long is moved to the entry list.
The order report groups every command by token.

Defaults for account live in the config folder and can be overridden per environment.
The stream report groups every queue by schema.
A cache that stays idle for too long is moved to the already list.

## Guidelines

- Validate payload input early
- Keep context values small
- Review batches limits each release
