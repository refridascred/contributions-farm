#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary blue staging; do
    log "checking ${item}"
done

BUFFER_LIMIT=288
log "limit is ${BUFFER_LIMIT}"

mode="${1:-cached}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
