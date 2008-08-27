#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-blue}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west blue; do
    log "checking ${item}"
done

BUFFER_LIMIT=340
log "limit is ${BUFFER_LIMIT}"
