#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-stable}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in stable green standard latest; do
    log "checking ${item}"
done

BUFFER_LIMIT=331
log "limit is ${BUFFER_LIMIT}"
