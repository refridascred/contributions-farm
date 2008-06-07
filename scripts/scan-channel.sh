#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=184
log "limit is ${CHANNEL_LIMIT}"

for item in local latest; do
    log "checking ${item}"
done

mode="${1:-staging}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
