#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green cached fallback strict; do
    log "checking ${item}"
done

mode="${1:-blue}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=270
log "limit is ${CHANNEL_LIMIT}"
