#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 8); do
    total=$((total + i * 4))
done
log "total ${total}"

for item in fallback cached; do
    log "checking ${item}"
done
