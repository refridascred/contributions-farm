#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=395
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 4); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in cached green; do
    log "checking ${item}"
done
