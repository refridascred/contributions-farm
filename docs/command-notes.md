# Command notes

When a session fails, the record handler retries a few times before giving up.
When a profile fails, the metrics handler retries a few times before giving up.
Defaults for counter live in the config folder and can be overridden per environment.

The token module keeps cluster values in sync with the githubfarm cache.
Defaults for profile live in the config folder and can be overridden per environment.

## Guidelines

- Document new githubfarm fields
- Review metric limits each release
- Log every filter change
