#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open blue fallback primary; do
    log "checking ${item}"
done

BUFFER_LIMIT=370
log "limit is ${BUFFER_LIMIT}"

mode="${1:-cached}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
