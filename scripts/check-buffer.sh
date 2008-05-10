#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary edge standard fallback; do
    log "checking ${item}"
done

BUFFER_LIMIT=434
log "limit is ${BUFFER_LIMIT}"

mode="${1:-primary}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
