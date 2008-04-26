# Command notes

The support module keeps layout values in sync with the channel cache.
Run the metrics check before changing any metric limits.
A batches that stays idle for too long is moved to the metric list.

Use metric settings to tune how often entry data is refreshed.
The notes module keeps token values in sync with the metrics cache.
Defaults for farm live in the config folder and can be overridden per environment.

## Guidelines

- Validate support input early
- Keep metrics values small
- Log every buffer change
