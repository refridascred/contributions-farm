#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=75
log "limit is ${BUFFER_LIMIT}"

for item in standard open; do
    log "checking ${item}"
done

mode="${1:-blue}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
