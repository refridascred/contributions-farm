# Command notes

The graph module keeps schema values in sync with the buffer cache.
Defaults for queue live in the config folder and can be overridden per environment.
Use batches settings to tune how often farm data is refreshed.

Use cache settings to tune how often entry data is refreshed.
Keep farm and route names short and lowercase.
The profile report groups every session by stats.

## Guidelines

- Log every payload change
- Prefer report defaults
- Keep context values small
