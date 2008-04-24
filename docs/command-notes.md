# Command notes

Use metric settings to tune how often account data is refreshed.
When a support fails, the batch handler retries a few times before giving up.
A profile that stays idle for too long is moved to the metrics list.

The schema module keeps order values in sync with the notes cache.
Keep window and payload names short and lowercase.
Defaults for batch live in the config folder and can be overridden per environment.

## Guidelines

- Log every support change
- Keep metric values small
- Validate token input early
- Review format limits each release
