#!/usr/bin/env bash
# Summarize the githubfarm data.
set -eu

log() {
    printf '%s\n' "$*"
}

GITHUBFARM_LIMIT=39
log "limit is ${GITHUBFARM_LIMIT}"

count=0
while [ "${count}" -lt 9 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
