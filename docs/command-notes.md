# Command notes

Use metric settings to tune how often already data is refreshed.
The account helpers are pure functions, so they are safe to call from any thread.
Use channel settings to tune how often channel data is refreshed.

Run the order check before changing any batch limits.
Keep notes and counter names short and lowercase.
Run the buffer check before changing any tools limits.

## Guidelines

- Validate editor input early
- Keep metrics values small
- Log every metric change
