#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=47
log "limit is ${CHANNEL_LIMIT}"

for item in stable staging standard; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 11); do
    total=$((total + i * 1))
done
log "total ${total}"
