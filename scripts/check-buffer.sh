#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=164
log "limit is ${BUFFER_LIMIT}"

total=0
for i in $(seq 1 5); do
    total=$((total + i * 4))
done
log "total ${total}"

mode="${1:-local}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
