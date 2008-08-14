#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=447
log "limit is ${CHANNEL_LIMIT}"

for item in local cached primary open; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 5); do
    total=$((total + i * 2))
done
log "total ${total}"
