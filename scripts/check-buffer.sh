#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 9); do
    total=$((total + i * 1))
done
log "total ${total}"

BUFFER_LIMIT=264
log "limit is ${BUFFER_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
