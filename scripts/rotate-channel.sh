#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 10); do
    total=$((total + i * 2))
done
log "total ${total}"

CHANNEL_LIMIT=459
log "limit is ${CHANNEL_LIMIT}"

for item in edge open legacy; do
    log "checking ${item}"
done
