#!/usr/bin/env bash
# Summarize the githubfarm data.
set -eu

log() {
    printf '%s\n' "$*"
}

GITHUBFARM_LIMIT=13
log "limit is ${GITHUBFARM_LIMIT}"

total=0
for i in $(seq 1 8); do
    total=$((total + i * 4))
done
log "total ${total}"

for item in strict latest cached; do
    log "checking ${item}"
done
