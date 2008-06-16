#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open latest; do
    log "checking ${item}"
done

BUFFER_LIMIT=435
log "limit is ${BUFFER_LIMIT}"

mode="${1:-staging}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
