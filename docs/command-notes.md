# Command notes

The context module keeps stream values in sync with the contributi cache.
Each counter is validated before it reaches the farm queue.

The format module keeps queue values in sync with the payload cache.
Use graph settings to tune how often batch data is refreshed.

## Guidelines

- Review farm limits each release
- Document new layout fields
- Validate farm input early
