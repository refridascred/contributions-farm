# Editor notes

Use stream settings to tune how often session data is refreshed.
Defaults for context live in the config folder and can be overridden per environment.
When a stream fails, the booking handler retries a few times before giving up.

Each stats is validated before it reaches the filter queue.
Each account is validated before it reaches the payload queue.
Defaults for metric live in the config folder and can be overridden per environment.

## Guidelines

- Document new support fields
- Review commits limits each release
- Log every context change
