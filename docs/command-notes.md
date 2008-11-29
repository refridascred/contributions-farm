# Command notes

The editor module keeps stats values in sync with the notes cache.
Keep already and entry names short and lowercase.
When a report fails, the batch handler retries a few times before giving up.

Use filter settings to tune how often record data is refreshed.
The githubfarm report groups every contributi by payload.
Defaults for notes live in the config folder and can be overridden per environment.

## Guidelines

- Log every farm change
- Keep window values small
- Review cache limits each release
- Validate filter input early
