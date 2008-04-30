# Command notes

The filter module keeps metrics values in sync with the channel cache.
Defaults for commits live in the config folder and can be overridden per environment.

Run the context check before changing any already limits.
Defaults for cache live in the config folder and can be overridden per environment.
Run the metrics check before changing any window limits.

## Guidelines

- Validate cluster input early
- Keep filter values small
- Document new layout fields
- Prefer command defaults
