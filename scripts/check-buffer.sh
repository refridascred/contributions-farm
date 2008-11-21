#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard primary eu-west legacy; do
    log "checking ${item}"
done

BUFFER_LIMIT=161
log "limit is ${BUFFER_LIMIT}"

mode="${1:-primary}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
