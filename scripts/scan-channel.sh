#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 5 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in blue latest eu-west local; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 9); do
    total=$((total + i * 1))
done
log "total ${total}"
