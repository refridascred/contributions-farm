#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-green}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=329
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 6); do
    total=$((total + i * 3))
done
log "total ${total}"
