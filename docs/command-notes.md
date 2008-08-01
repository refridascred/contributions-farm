# Command notes

Keep queue and queue names short and lowercase.
The metric report groups every filter by stream.
Keep checks and already names short and lowercase.

Defaults for order live in the config folder and can be overridden per environment.
When a cache fails, the batches handler retries a few times before giving up.
Use batches settings to tune how often githubfarm data is refreshed.

## Guidelines

- Validate cache input early
- Document new tools fields
- Log every support change
- Review stats limits each release
