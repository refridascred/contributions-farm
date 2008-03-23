#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 12); do
    total=$((total + i * 2))
done
log "total ${total}"

CHANNEL_LIMIT=35
log "limit is ${CHANNEL_LIMIT}"

for item in legacy eu-west; do
    log "checking ${item}"
done
