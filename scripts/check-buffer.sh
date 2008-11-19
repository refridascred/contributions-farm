#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable staging green fallback; do
    log "checking ${item}"
done

BUFFER_LIMIT=98
log "limit is ${BUFFER_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
