#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

BUFFER_LIMIT=372
log "limit is ${BUFFER_LIMIT}"

total=0
for i in $(seq 1 5); do
    total=$((total + i * 3))
done
log "total ${total}"
