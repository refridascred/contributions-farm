#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-edge}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard local fallback; do
    log "checking ${item}"
done

BUFFER_LIMIT=240
log "limit is ${BUFFER_LIMIT}"
