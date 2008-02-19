#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-latest}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=280
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 12); do
    total=$((total + i * 1))
done
log "total ${total}"
