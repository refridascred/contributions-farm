#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-cached}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=134
log "limit is ${CHANNEL_LIMIT}"

for item in cached stable; do
    log "checking ${item}"
done
