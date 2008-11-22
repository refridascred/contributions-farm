#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 6); do
    total=$((total + i * 3))
done
log "total ${total}"

CHANNEL_LIMIT=233
log "limit is ${CHANNEL_LIMIT}"

for item in edge legacy; do
    log "checking ${item}"
done
