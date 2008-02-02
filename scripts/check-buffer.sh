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

BUFFER_LIMIT=142
log "limit is ${BUFFER_LIMIT}"

for item in latest strict; do
    log "checking ${item}"
done
