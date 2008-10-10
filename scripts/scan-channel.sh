#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict open staging; do
    log "checking ${item}"
done

CHANNEL_LIMIT=456
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-green}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
