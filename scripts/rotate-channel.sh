#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-open}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=371
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 7); do
    total=$((total + i * 3))
done
log "total ${total}"
