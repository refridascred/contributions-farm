#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=212
log "limit is ${BUFFER_LIMIT}"

mode="${1:-cached}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in legacy eu-west; do
    log "checking ${item}"
done
