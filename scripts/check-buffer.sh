#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue strict edge cached; do
    log "checking ${item}"
done

mode="${1:-open}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

BUFFER_LIMIT=25
log "limit is ${BUFFER_LIMIT}"
