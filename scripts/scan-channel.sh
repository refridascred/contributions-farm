#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=209
log "limit is ${CHANNEL_LIMIT}"

for item in strict blue latest primary; do
    log "checking ${item}"
done
