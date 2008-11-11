#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-local}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in local primary; do
    log "checking ${item}"
done

BUFFER_LIMIT=117
log "limit is ${BUFFER_LIMIT}"
