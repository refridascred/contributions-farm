#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 8); do
    total=$((total + i * 4))
done
log "total ${total}"

for item in eu-west legacy stable open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=66
log "limit is ${CHANNEL_LIMIT}"
