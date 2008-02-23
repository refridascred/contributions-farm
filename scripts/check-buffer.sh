#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=300
log "limit is ${BUFFER_LIMIT}"

for item in open edge strict; do
    log "checking ${item}"
done

mode="${1:-green}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
