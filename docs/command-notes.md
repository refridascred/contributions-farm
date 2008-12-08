# Command notes

Use context settings to tune how often metrics data is refreshed.
Use checks settings to tune how often farm data is refreshed.
Defaults for window live in the config folder and can be overridden per environment.

Use githubfarm settings to tune how often record data is refreshed.
The stats module keeps route values in sync with the payload cache.
Each stats is validated before it reaches the token queue.

## Guidelines

- Validate stats input early
- Prefer metrics defaults
- Log every buffer change
