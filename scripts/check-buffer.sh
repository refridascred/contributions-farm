#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-blue}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

BUFFER_LIMIT=361
log "limit is ${BUFFER_LIMIT}"

total=0
for i in $(seq 1 9); do
    total=$((total + i * 5))
done
log "total ${total}"
