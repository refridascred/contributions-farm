#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard stable legacy; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 9); do
    total=$((total + i * 1))
done
log "total ${total}"

CHANNEL_LIMIT=366
log "limit is ${CHANNEL_LIMIT}"
