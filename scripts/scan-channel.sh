#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest local cached legacy; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 9); do
    total=$((total + i * 4))
done
log "total ${total}"
