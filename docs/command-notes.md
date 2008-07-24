# Command notes

The schema module keeps cache values in sync with the layout cache.
Run the profile check before changing any batches limits.

The support helpers are pure functions, so they are safe to call from any thread.
Defaults for format live in the config folder and can be overridden per environment.
The farm report groups every batch by contributi.

## Guidelines

- Log every buffer change
- Document new checks fields
- Review githubfarm limits each release
