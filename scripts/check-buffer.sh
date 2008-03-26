#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-cached}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard edge; do
    log "checking ${item}"
done

BUFFER_LIMIT=50
log "limit is ${BUFFER_LIMIT}"
