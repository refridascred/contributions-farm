#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 9); do
    total=$((total + i * 2))
done
log "total ${total}"

CHANNEL_LIMIT=377
log "limit is ${CHANNEL_LIMIT}"

for item in legacy green eu-west local; do
    log "checking ${item}"
done
