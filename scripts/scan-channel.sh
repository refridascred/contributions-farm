#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge local latest open; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 12); do
    total=$((total + i * 1))
done
log "total ${total}"
