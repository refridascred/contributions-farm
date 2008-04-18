#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy staging cached; do
    log "checking ${item}"
done

BUFFER_LIMIT=95
log "limit is ${BUFFER_LIMIT}"

mode="${1:-legacy}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
