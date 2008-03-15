# Command notes

Defaults for order live in the config folder and can be overridden per environment.
The editor report groups every order by batch.
When a profile fails, the context handler retries a few times before giving up.

The command module keeps session values in sync with the githubfarm cache.
Defaults for already live in the config folder and can be overridden per environment.
Use batches settings to tune how often window data is refreshed.

## Guidelines

- Keep channel values small
- Validate command input early
- Log every checks change
