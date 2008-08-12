#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-stable}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict stable; do
    log "checking ${item}"
done

CHANNEL_LIMIT=76
log "limit is ${CHANNEL_LIMIT}"
