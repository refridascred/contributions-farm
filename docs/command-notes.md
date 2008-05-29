# Command notes

Run the farm check before changing any format limits.
Run the tools check before changing any stream limits.

When a layout fails, the batches handler retries a few times before giving up.
Defaults for support live in the config folder and can be overridden per environment.

## Guidelines

- Document new account fields
- Validate format input early
- Log every entry change
- Review command limits each release
