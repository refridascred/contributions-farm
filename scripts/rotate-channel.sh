#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 8); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in stable staging standard edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=67
log "limit is ${CHANNEL_LIMIT}"
