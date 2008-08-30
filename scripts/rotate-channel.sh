#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=140
log "limit is ${CHANNEL_LIMIT}"

total=0
for i in $(seq 1 9); do
    total=$((total + i * 2))
done
log "total ${total}"

for item in eu-west latest; do
    log "checking ${item}"
done
