#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue staging; do
    log "checking ${item}"
done

BUFFER_LIMIT=321
log "limit is ${BUFFER_LIMIT}"

mode="${1:-fallback}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
