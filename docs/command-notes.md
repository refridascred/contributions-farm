# Command notes

Defaults for editor live in the config folder and can be overridden per environment.
Run the filter check before changing any queue limits.
When a order fails, the token handler retries a few times before giving up.

Each checks is validated before it reaches the support queue.
Run the order check before changing any notes limits.

## Guidelines

- Log every metrics change
- Validate account input early
- Review notes limits each release
