#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 11); do
    total=$((total + i * 5))
done
log "total ${total}"

CHANNEL_LIMIT=264
log "limit is ${CHANNEL_LIMIT}"

for item in green primary; do
    log "checking ${item}"
done
