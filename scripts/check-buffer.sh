#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 7); do
    total=$((total + i * 5))
done
log "total ${total}"

BUFFER_LIMIT=472
log "limit is ${BUFFER_LIMIT}"

mode="${1:-edge}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
