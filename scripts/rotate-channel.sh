#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=423
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 3); do
    total=$((total + i * 4))
done
log "total ${total}"

for item in cached latest staging; do
    log "checking ${item}"
done
