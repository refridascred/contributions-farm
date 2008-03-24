#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=279
log "limit is ${BUFFER_LIMIT}"

total=0
for i in $(seq 1 6); do
    total=$((total + i * 2))
done
log "total ${total}"

mode="${1:-stable}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
