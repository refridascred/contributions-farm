#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-staging}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=304
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 12); do
    total=$((total + i * 5))
done
log "total ${total}"
