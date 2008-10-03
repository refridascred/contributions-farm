# Command notes

The batches module keeps schema values in sync with the token cache.
Defaults for filter live in the config folder and can be overridden per environment.
The command report groups every buffer by counter.

Use payload settings to tune how often context data is refreshed.
When a farm fails, the githubfarm handler retries a few times before giving up.
Use profile settings to tune how often farm data is refreshed.

## Guidelines

- Validate cache input early
- Keep stream values small
- Prefer queue defaults
