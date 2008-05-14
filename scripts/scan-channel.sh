#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 7); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in standard edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=119
log "limit is ${CHANNEL_LIMIT}"
