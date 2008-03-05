#!/usr/bin/env bash
# Summarize the githubfarm data.
set -eu

log() {
    printf '%s\n' "$*"
}

count=0
while [ "${count}" -lt 9 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"

for item in eu-west stable; do
    log "checking ${item}"
done

GITHUBFARM_LIMIT=448
log "limit is ${GITHUBFARM_LIMIT}"
