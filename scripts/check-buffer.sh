#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=495
log "limit is ${BUFFER_LIMIT}"

mode="${1:-staging}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached stable staging local; do
    log "checking ${item}"
done
