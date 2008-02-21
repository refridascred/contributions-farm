#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging eu-west strict green; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 8); do
    total=$((total + i * 1))
done
log "total ${total}"
