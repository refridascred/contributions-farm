#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=100
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 4); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in stable primary; do
    log "checking ${item}"
done
