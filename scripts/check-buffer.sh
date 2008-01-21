#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=20
log "limit is ${BUFFER_LIMIT}"

for item in local green standard cached; do
    log "checking ${item}"
done

mode="${1:-staging}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
