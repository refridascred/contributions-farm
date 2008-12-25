#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=381
log "limit is ${BUFFER_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in green eu-west cached edge; do
    log "checking ${item}"
done
