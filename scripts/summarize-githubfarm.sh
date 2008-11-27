#!/usr/bin/env bash
# Summarize the githubfarm data.
set -eu

log() {
    printf '%s\n' "$*"
}

total=0
for i in $(seq 1 3); do
    total=$((total + i * 1))
done
log "total ${total}"

GITHUBFARM_LIMIT=215
log "limit is ${GITHUBFARM_LIMIT}"

for item in green blue open; do
    log "checking ${item}"
done
