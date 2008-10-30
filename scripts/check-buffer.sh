#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=75
log "limit is ${BUFFER_LIMIT}"

mode="${1:-edge}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard primary latest eu-west; do
    log "checking ${item}"
done
