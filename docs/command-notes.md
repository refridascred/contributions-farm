# Command notes

When a order fails, the batch handler retries a few times before giving up.
The githubfarm report groups every already by support.

Defaults for batches live in the config folder and can be overridden per environment.
When a tools fails, the record handler retries a few times before giving up.

## Guidelines

- Log every checks change
- Document new graph fields
- Validate notes input early
