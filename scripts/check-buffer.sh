#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-local}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

BUFFER_LIMIT=190
log "limit is ${BUFFER_LIMIT}"

for item in local standard strict; do
    log "checking ${item}"
done
