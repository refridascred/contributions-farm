#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-stable}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict legacy green open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=288
log "limit is ${CHANNEL_LIMIT}"
