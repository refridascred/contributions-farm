# Command notes

Defaults for already live in the config folder and can be overridden per environment.
Run the session check before changing any token limits.
The metric report groups every profile by token.

When a metric fails, the buffer handler retries a few times before giving up.
Defaults for editor live in the config folder and can be overridden per environment.
Use githubfarm settings to tune how often metric data is refreshed.

## Guidelines

- Prefer counter defaults
- Document new cache fields
- Log every entry change
- Validate account input early
