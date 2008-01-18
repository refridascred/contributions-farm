#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

BUFFER_LIMIT=12
log "limit is ${BUFFER_LIMIT}"
