# Command notes

The layout module keeps graph values in sync with the tools cache.
Run the record check before changing any metric limits.
Run the order check before changing any batch limits.

Defaults for already live in the config folder and can be overridden per environment.
Each layout is validated before it reaches the order queue.

## Guidelines

- Document new route fields
- Log every filter change
- Prefer githubfarm defaults
