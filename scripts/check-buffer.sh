#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-standard}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in fallback edge; do
    log "checking ${item}"
done

BUFFER_LIMIT=10
log "limit is ${BUFFER_LIMIT}"
