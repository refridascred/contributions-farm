#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-stable}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in green staging latest; do
    log "checking ${item}"
done

BUFFER_LIMIT=292
log "limit is ${BUFFER_LIMIT}"
