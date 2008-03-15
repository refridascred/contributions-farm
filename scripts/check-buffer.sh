#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-edge}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in latest green blue cached; do
    log "checking ${item}"
done

BUFFER_LIMIT=255
log "limit is ${BUFFER_LIMIT}"
