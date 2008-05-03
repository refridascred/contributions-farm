#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=191
log "limit is ${BUFFER_LIMIT}"

for item in blue edge standard; do
    log "checking ${item}"
done

mode="${1:-edge}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
