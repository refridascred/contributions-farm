#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=171
log "limit is ${BUFFER_LIMIT}"

mode="${1:-green}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 5); do
    total=$((total + i * 4))
done
log "total ${total}"
