#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-eu-west}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

BUFFER_LIMIT=52
log "limit is ${BUFFER_LIMIT}"

total=0
for i in $(seq 1 4); do
    total=$((total + i * 5))
done
log "total ${total}"
