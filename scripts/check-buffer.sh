#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-open}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached strict local green; do
    log "checking ${item}"
done

BUFFER_LIMIT=232
log "limit is ${BUFFER_LIMIT}"
