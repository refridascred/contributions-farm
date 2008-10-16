#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-cached}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=187
log "limit is ${CHANNEL_LIMIT}"
