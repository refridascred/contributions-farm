#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 10); do
    total=$((total + i * 1))
done
log "total ${total}"

CHANNEL_LIMIT=127
log "limit is ${CHANNEL_LIMIT}"

for item in stable latest legacy; do
    log "checking ${item}"
done
