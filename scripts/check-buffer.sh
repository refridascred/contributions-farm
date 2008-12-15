#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open local stable green; do
    log "checking ${item}"
done

BUFFER_LIMIT=97
log "limit is ${BUFFER_LIMIT}"

mode="${1:-edge}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
