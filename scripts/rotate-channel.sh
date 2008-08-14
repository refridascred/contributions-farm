#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard edge local; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 6); do
    total=$((total + i * 1))
done
log "total ${total}"

CHANNEL_LIMIT=122
log "limit is ${CHANNEL_LIMIT}"
