#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached latest staging fallback; do
    log "checking ${item}"
done

BUFFER_LIMIT=390
log "limit is ${BUFFER_LIMIT}"

mode="${1:-local}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
