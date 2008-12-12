#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=283
log "limit is ${BUFFER_LIMIT}"

for item in standard green primary open; do
    log "checking ${item}"
done

mode="${1:-edge}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
