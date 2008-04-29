#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-edge}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=202
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 8); do
    total=$((total + i * 4))
done
log "total ${total}"
