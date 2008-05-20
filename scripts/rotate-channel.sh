#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 4); do
    total=$((total + i * 2))
done
log "total ${total}"

for item in stable latest; do
    log "checking ${item}"
done
