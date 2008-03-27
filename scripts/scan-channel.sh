#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary local edge; do
    log "checking ${item}"
done

mode="${1:-blue}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=141
log "limit is ${CHANNEL_LIMIT}"
