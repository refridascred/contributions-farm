#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=498
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 10); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in legacy primary staging; do
    log "checking ${item}"
done
