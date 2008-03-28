#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest stable; do
    log "checking ${item}"
done

BUFFER_LIMIT=105
log "limit is ${BUFFER_LIMIT}"

mode="${1:-standard}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
