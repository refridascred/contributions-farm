#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard fallback cached edge; do
    log "checking ${item}"
done

mode="${1:-green}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

BUFFER_LIMIT=361
log "limit is ${BUFFER_LIMIT}"
