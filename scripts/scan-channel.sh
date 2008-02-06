#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=434
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-green}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

total=0
for i in $(seq 1 8); do
    total=$((total + i * 4))
done
log "total ${total}"
