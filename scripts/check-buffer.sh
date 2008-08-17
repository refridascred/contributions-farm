#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-green}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

BUFFER_LIMIT=406
log "limit is ${BUFFER_LIMIT}"

for item in standard open; do
    log "checking ${item}"
done
