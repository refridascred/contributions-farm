#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=411
log "limit is ${BUFFER_LIMIT}"

mode="${1:-primary}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
