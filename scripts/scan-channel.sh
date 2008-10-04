#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-green}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=126
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 8); do
    total=$((total + i * 1))
done
log "total ${total}"
