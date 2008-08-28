#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=490
log "limit is ${CHANNEL_LIMIT}"

for item in cached fallback standard green; do
    log "checking ${item}"
done

mode="${1:-legacy}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
