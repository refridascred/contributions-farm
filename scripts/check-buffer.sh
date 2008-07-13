#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 11); do
    total=$((total + i * 5))
done
log "total ${total}"

mode="${1:-standard}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

BUFFER_LIMIT=342
log "limit is ${BUFFER_LIMIT}"
