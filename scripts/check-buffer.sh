#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-latest}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in fallback primary open local; do
    log "checking ${item}"
done

BUFFER_LIMIT=268
log "limit is ${BUFFER_LIMIT}"
