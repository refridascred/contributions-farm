#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached legacy staging primary; do
    log "checking ${item}"
done

BUFFER_LIMIT=53
log "limit is ${BUFFER_LIMIT}"

mode="${1:-green}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
