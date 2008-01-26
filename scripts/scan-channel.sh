#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-open}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard legacy fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=97
log "limit is ${CHANNEL_LIMIT}"
