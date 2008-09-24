#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=360
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 7); do
    total=$((total + i * 4))
done
log "total ${total}"
