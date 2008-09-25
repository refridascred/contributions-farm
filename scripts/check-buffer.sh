#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-open}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict blue; do
    log "checking ${item}"
done

BUFFER_LIMIT=9
log "limit is ${BUFFER_LIMIT}"
