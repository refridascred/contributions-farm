# Command notes

Use layout settings to tune how often buffer data is refreshed.
Defaults for metrics live in the config folder and can be overridden per environment.
Run the context check before changing any window limits.

When a already fails, the githubfarm handler retries a few times before giving up.
Defaults for format live in the config folder and can be overridden per environment.
Use counter settings to tune how often batch data is refreshed.

## Guidelines

- Review session limits each release
- Validate token input early
- Log every channel change
- Keep report values small
