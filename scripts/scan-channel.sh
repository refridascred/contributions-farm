#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=125
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-blue}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 6); do
    total=$((total + i * 4))
done
log "total ${total}"
