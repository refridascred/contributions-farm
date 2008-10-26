#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-blue}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in staging open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=482
log "limit is ${CHANNEL_LIMIT}"
