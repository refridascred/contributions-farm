#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 4 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

mode="${1:-stable}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

BUFFER_LIMIT=420
log "limit is ${BUFFER_LIMIT}"
