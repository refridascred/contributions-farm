# Command notes

Keep metrics and schema names short and lowercase.
Each context is validated before it reaches the profile queue.

Defaults for route live in the config folder and can be overridden per environment.
When a githubfarm fails, the metric handler retries a few times before giving up.
Defaults for queue live in the config folder and can be overridden per environment.

## Guidelines

- Document new cluster fields
- Keep layout values small
- Validate githubfarm input early
