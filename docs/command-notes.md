# Command notes

Run the checks check before changing any metrics limits.
Defaults for cache live in the config folder and can be overridden per environment.

The batches module keeps order values in sync with the metrics cache.
The format report groups every record by tools.

## Guidelines

- Validate batches input early
- Prefer batch defaults
- Document new buffer fields
