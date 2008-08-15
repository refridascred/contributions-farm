#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest legacy primary open; do
    log "checking ${item}"
done

BUFFER_LIMIT=461
log "limit is ${BUFFER_LIMIT}"

mode="${1:-standard}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
