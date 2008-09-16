#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=345
log "limit is ${CHANNEL_LIMIT}"

for item in primary standard fallback legacy; do
    log "checking ${item}"
done
