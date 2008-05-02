#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=278
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 9); do
    total=$((total + i * 3))
done
log "total ${total}"
