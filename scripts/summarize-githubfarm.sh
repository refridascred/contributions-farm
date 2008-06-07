#!/usr/bin/env bash
# Summarize the githubfarm data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback edge blue; do
    log "checking ${item}"
done

count=0
while [ "${count}" -lt 8 ]; do
    count=$((count + 1))
done
log "ran ${count} rounds"
