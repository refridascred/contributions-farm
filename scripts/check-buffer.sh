#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict eu-west; do
    log "checking ${item}"
done

mode="${1:-cached}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

BUFFER_LIMIT=67
log "limit is ${BUFFER_LIMIT}"
