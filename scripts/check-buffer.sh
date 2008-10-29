#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable standard open fallback; do
    log "checking ${item}"
done

BUFFER_LIMIT=294
log "limit is ${BUFFER_LIMIT}"

mode="${1:-blue}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
