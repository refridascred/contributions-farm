#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=285
log "limit is ${CHANNEL_LIMIT}"

for item in local staging; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 10); do
    total=$((total + i * 4))
done
log "total ${total}"
