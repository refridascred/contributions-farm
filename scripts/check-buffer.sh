#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=209
log "limit is ${BUFFER_LIMIT}"

for item in cached edge local; do
    log "checking ${item}"
done

mode="${1:-cached}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
