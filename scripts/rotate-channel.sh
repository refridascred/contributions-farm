#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 10); do
    total=$((total + i * 1))
done
log "total ${total}"

mode="${1:-green}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=445
log "limit is ${CHANNEL_LIMIT}"
