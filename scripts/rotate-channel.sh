#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 7); do
    total=$((total + i * 3))
done
log "total ${total}"

CHANNEL_LIMIT=137
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-green}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
