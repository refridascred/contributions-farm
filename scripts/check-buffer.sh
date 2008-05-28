#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west strict; do
    log "checking ${item}"
done

BUFFER_LIMIT=328
log "limit is ${BUFFER_LIMIT}"

mode="${1:-standard}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
