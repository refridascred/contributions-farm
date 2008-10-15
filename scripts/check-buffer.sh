#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback edge; do
    log "checking ${item}"
done

BUFFER_LIMIT=135
log "limit is ${BUFFER_LIMIT}"

mode="${1:-green}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
