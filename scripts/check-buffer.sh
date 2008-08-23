#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard eu-west green local; do
    log "checking ${item}"
done

BUFFER_LIMIT=295
log "limit is ${BUFFER_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
