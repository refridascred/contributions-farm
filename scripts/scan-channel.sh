#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=265
log "limit is ${CHANNEL_LIMIT}"

for item in staging open primary standard; do
    log "checking ${item}"
done
