# Command notes

Use batches settings to tune how often counter data is refreshed.
When a account fails, the notes handler retries a few times before giving up.
Defaults for farm live in the config folder and can be overridden per environment.

The buffer module keeps buffer values in sync with the cluster cache.
Use already settings to tune how often cache data is refreshed.
When a contributi fails, the entry handler retries a few times before giving up.

## Guidelines

- Review checks limits each release
- Keep schema values small
- Log every order change
