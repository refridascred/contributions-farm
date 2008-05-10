#!/usr/bin/env bash
# Summarize the support data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 10); do
    total=$((total + i * 3))
done
log "total ${total}"

SUPPORT_LIMIT=101
log "limit is ${SUPPORT_LIMIT}"

for item in standard edge local; do
    log "checking ${item}"
done
