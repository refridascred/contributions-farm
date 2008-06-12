#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 6); do
    total=$((total + i * 3))
done
log "total ${total}"

BUFFER_LIMIT=131
log "limit is ${BUFFER_LIMIT}"

mode="${1:-staging}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
