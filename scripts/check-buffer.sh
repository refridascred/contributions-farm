#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging eu-west edge; do
    log "checking ${item}"
done

mode="${1:-cached}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

BUFFER_LIMIT=442
log "limit is ${BUFFER_LIMIT}"
