#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=266
log "limit is ${BUFFER_LIMIT}"

for item in cached edge stable; do
    log "checking ${item}"
done

mode="${1:-eu-west}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
