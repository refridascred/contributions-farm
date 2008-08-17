#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=468
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 7); do
    total=$((total + i * 3))
done
log "total ${total}"

mode="${1:-standard}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
