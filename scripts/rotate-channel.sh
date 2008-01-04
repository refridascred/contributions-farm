#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=138
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 4); do
    total=$((total + i * 2))
done
log "total ${total}"
