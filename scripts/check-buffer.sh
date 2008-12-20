#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging stable; do
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

BUFFER_LIMIT=318
log "limit is ${BUFFER_LIMIT}"
