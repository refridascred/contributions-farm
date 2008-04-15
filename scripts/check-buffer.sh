#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard open; do
    log "checking ${item}"
done

BUFFER_LIMIT=229
log "limit is ${BUFFER_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
