#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging legacy primary; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 5); do
    total=$((total + i * 3))
done
log "total ${total}"
