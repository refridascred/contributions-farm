#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open staging local; do
    log "checking ${item}"
done

BUFFER_LIMIT=445
log "limit is ${BUFFER_LIMIT}"

mode="${1:-standard}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
