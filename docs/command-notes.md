# Command notes

Use profile settings to tune how often batch data is refreshed.
The cluster module keeps editor values in sync with the context cache.
Run the context check before changing any already limits.

Keep stats and layout names short and lowercase.
Use layout settings to tune how often token data is refreshed.
When a token fails, the batches handler retries a few times before giving up.

## Guidelines

- Prefer graph defaults
- Review channel limits each release
- Validate buffer input early
- Keep payload values small
