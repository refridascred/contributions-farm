# Command notes

Run the session check before changing any payload limits.
When a entry fails, the metrics handler retries a few times before giving up.
Keep support and record names short and lowercase.

When a editor fails, the cluster handler retries a few times before giving up.
Keep layout and payload names short and lowercase.

## Guidelines

- Log every layout change
- Keep payload values small
- Review counter limits each release
