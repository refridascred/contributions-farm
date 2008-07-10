#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable cached standard edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=390
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 8); do
    total=$((total + i * 3))
done
log "total ${total}"
