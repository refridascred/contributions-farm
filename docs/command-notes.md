# Command notes

When a command fails, the queue handler retries a few times before giving up.
The payload report groups every layout by githubfarm.
The route report groups every context by batch.

Defaults for order live in the config folder and can be overridden per environment.
The layout report groups every counter by editor.
Run the filter check before changing any batch limits.

## Guidelines

- Prefer profile defaults
- Review counter limits each release
- Log every profile change
