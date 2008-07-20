#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 7); do
    total=$((total + i * 2))
done
log "total ${total}"

mode="${1:-staging}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

BUFFER_LIMIT=10
log "limit is ${BUFFER_LIMIT}"
