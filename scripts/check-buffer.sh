#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=438
log "limit is ${BUFFER_LIMIT}"

for item in fallback strict; do
    log "checking ${item}"
done

mode="${1:-eu-west}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
