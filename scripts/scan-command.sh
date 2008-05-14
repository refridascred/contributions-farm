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

for item in legacy eu-west edge; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 6); do
    total=$((total + i * 4))
done
log "total ${total}"
