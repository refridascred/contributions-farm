# Command notes

The batch module keeps tools values in sync with the filter cache.
Each payload is validated before it reaches the context queue.
The report module keeps command values in sync with the order cache.

Run the githubfarm check before changing any stream limits.
Use metric settings to tune how often token data is refreshed.
The contributi report groups every report by queue.

## Guidelines

- Log every buffer change
- Validate githubfarm input early
- Keep checks values small
