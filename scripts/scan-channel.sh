#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=323
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 9); do
    total=$((total + i * 1))
done
log "total ${total}"

mode="${1:-cached}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
