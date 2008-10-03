#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local stable; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 6); do
    total=$((total + i * 3))
done
log "total ${total}"
