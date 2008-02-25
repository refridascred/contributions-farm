# Command notes

The route module keeps queue values in sync with the batches cache.
The account module keeps already values in sync with the batch cache.
Use payload settings to tune how often context data is refreshed.

## Guidelines

- Prefer farm defaults
- Validate payload input early
- Review format limits each release
- Log every githubfarm change
