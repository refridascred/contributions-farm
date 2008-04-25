#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge staging latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=424
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 8); do
    total=$((total + i * 2))
done
log "total ${total}"
