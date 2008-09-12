#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=203
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 5); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in stable cached strict; do
    log "checking ${item}"
done
