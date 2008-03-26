#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=204
log "limit is ${BUFFER_LIMIT}"

total=0
for i in $(seq 1 11); do
    total=$((total + i * 5))
done
log "total ${total}"

mode="${1:-cached}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
