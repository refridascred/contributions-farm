#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict latest edge local; do
    log "checking ${item}"
done

BUFFER_LIMIT=136
log "limit is ${BUFFER_LIMIT}"

mode="${1:-local}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
