# Command notes

The format module keeps token values in sync with the record cache.
Keep githubfarm and commits names short and lowercase.

Each githubfarm is validated before it reaches the metric queue.
When a batches fails, the token handler retries a few times before giving up.
The payload report groups every queue by order.

## Guidelines

- Document new payload fields
- Prefer entry defaults
- Review token limits each release
- Log every route change
