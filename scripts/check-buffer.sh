#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=394
log "limit is ${BUFFER_LIMIT}"

mode="${1:-local}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open cached eu-west stable; do
    log "checking ${item}"
done
