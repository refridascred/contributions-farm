#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-green}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west cached blue; do
    log "checking ${item}"
done

BUFFER_LIMIT=101
log "limit is ${BUFFER_LIMIT}"
