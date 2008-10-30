# Command notes

Defaults for record live in the config folder and can be overridden per environment.
When a context fails, the graph handler retries a few times before giving up.

When a record fails, the githubfarm handler retries a few times before giving up.
Defaults for cluster live in the config folder and can be overridden per environment.

## Guidelines

- Review token limits each release
- Document new profile fields
- Validate route input early
- Keep record values small
