#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy fallback cached staging; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 11); do
    total=$((total + i * 2))
done
log "total ${total}"
