#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict fallback local staging; do
    log "checking ${item}"
done

CHANNEL_LIMIT=223
log "limit is ${CHANNEL_LIMIT}"
