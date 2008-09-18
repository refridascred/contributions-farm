# Command notes

When a buffer fails, the githubfarm handler retries a few times before giving up.
Keep command and support names short and lowercase.

Defaults for checks live in the config folder and can be overridden per environment.
The order module keeps buffer values in sync with the account cache.

## Guidelines

- Document new queue fields
- Validate stream input early
- Review githubfarm limits each release
