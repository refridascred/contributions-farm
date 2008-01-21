#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-open}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in legacy strict cached local; do
    log "checking ${item}"
done

BUFFER_LIMIT=251
log "limit is ${BUFFER_LIMIT}"
