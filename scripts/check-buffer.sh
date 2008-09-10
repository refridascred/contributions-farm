#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=404
log "limit is ${BUFFER_LIMIT}"

mode="${1:-blue}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
