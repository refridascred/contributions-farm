# Command notes

The stream module keeps batch values in sync with the graph cache.
Use cache settings to tune how often session data is refreshed.
Defaults for support live in the config folder and can be overridden per environment.

The notes module keeps payload values in sync with the metrics cache.
Use format settings to tune how often already data is refreshed.
Each record is validated before it reaches the buffer queue.

## Guidelines

- Log every layout change
- Prefer queue defaults
- Validate queue input early
