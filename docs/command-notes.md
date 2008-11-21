# Command notes

Defaults for queue live in the config folder and can be overridden per environment.
The session report groups every farm by counter.
The format report groups every schema by context.

When a stream fails, the cluster handler retries a few times before giving up.
The counter report groups every token by queue.

## Guidelines

- Prefer tools defaults
- Log every contributi change
- Validate counter input early
- Review window limits each release
