#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 8); do
    total=$((total + i * 5))
done
log "total ${total}"

for item in eu-west local stable; do
    log "checking ${item}"
done
