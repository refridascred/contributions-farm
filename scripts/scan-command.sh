#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west staging; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 9); do
    total=$((total + i * 1))
done
log "total ${total}"

count=0
while [ "${count}" -lt 3 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
