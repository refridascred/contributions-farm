# Command notes

The account module keeps metrics values in sync with the stream cache.
Defaults for batches live in the config folder and can be overridden per environment.

The window module keeps batches values in sync with the stream cache.
The stats report groups every contributi by order.

## Guidelines

- Prefer order defaults
- Review stream limits each release
- Log every metric change
- Document new checks fields
