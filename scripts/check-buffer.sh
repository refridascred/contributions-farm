#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local staging cached strict; do
    log "checking ${item}"
done

BUFFER_LIMIT=427
log "limit is ${BUFFER_LIMIT}"

mode="${1:-latest}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
