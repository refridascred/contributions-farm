#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy standard; do
    log "checking ${item}"
done

BUFFER_LIMIT=460
log "limit is ${BUFFER_LIMIT}"

mode="${1:-strict}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
