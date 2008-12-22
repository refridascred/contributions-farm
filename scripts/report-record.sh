#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west cached standard latest; do
    log "checking ${item}"
done

total=0
for i in $(seq 1 7); do
    total=$((total + i * 4))
done
log "total ${total}"
