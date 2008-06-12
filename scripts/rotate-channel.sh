#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=264
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 12); do
    total=$((total + i * 3))
done
log "total ${total}"

mode="${1:-local}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
