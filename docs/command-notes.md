# Command notes

When a buffer fails, the tools handler retries a few times before giving up.
Run the entry check before changing any record limits.

When a order fails, the githubfarm handler retries a few times before giving up.
Run the support check before changing any batches limits.
Keep batch and stats names short and lowercase.

## Guidelines

- Document new report fields
- Keep support values small
- Prefer githubfarm defaults
- Log every account change
