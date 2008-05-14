#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard staging blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=114
log "limit is ${CHANNEL_LIMIT}"
