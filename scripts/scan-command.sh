#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 2 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

total=0
for i in $(seq 1 7); do
    total=$((total + i * 2))
done
log "total ${total}"

for item in standard green local legacy; do
    log "checking ${item}"
done
