#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west primary staging; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 3); do
    total=$((total + i * 1))
done
log "total ${total}"
