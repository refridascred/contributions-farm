#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=208
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 11); do
    total=$((total + i * 3))
done
log "total ${total}"

for item in open staging legacy; do
    log "checking ${item}"
done
