# Command notes

Run the profile check before changing any profile limits.
Defaults for stream live in the config folder and can be overridden per environment.
The layout module keeps stats values in sync with the context cache.

Use queue settings to tune how often entry data is refreshed.
When a route fails, the graph handler retries a few times before giving up.
Use payload settings to tune how often batches data is refreshed.

## Guidelines

- Document new report fields
- Log every token change
- Prefer order defaults
