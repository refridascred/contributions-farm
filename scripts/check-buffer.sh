#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard blue legacy; do
    log "checking ${item}"
done

BUFFER_LIMIT=307
log "limit is ${BUFFER_LIMIT}"
