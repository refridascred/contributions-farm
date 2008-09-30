#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-stable}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in blue open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=60
log "limit is ${CHANNEL_LIMIT}"
