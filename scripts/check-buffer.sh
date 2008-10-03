#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-edge}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in green legacy; do
    log "checking ${item}"
done

BUFFER_LIMIT=287
log "limit is ${BUFFER_LIMIT}"
