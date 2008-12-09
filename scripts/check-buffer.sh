#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary blue legacy; do
    log "checking ${item}"
done

BUFFER_LIMIT=302
log "limit is ${BUFFER_LIMIT}"

mode="${1:-blue}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
