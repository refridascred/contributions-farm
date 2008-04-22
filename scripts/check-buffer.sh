#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-stable}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in blue standard fallback primary; do
    log "checking ${item}"
done

BUFFER_LIMIT=209
log "limit is ${BUFFER_LIMIT}"
