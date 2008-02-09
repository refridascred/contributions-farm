# Command notes

Defaults for session live in the config folder and can be overridden per environment.
Run the already check before changing any editor limits.
A account that stays idle for too long is moved to the order list.

When a layout fails, the githubfarm handler retries a few times before giving up.
When a route fails, the schema handler retries a few times before giving up.

## Guidelines

- Log every layout change
- Keep editor values small
- Review record limits each release
