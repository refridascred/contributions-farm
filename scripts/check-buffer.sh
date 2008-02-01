#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=170
log "limit is ${BUFFER_LIMIT}"

mode="${1:-local}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 8); do
    total=$((total + i * 2))
done
log "total ${total}"
