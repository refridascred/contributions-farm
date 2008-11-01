#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=228
log "limit is ${CHANNEL_LIMIT}"

for item in standard cached edge latest; do
    log "checking ${item}"
done

mode="${1:-green}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
