#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=456
log "limit is ${BUFFER_LIMIT}"

mode="${1:-standard}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 6); do
    total=$((total + i * 5))
done
log "total ${total}"
