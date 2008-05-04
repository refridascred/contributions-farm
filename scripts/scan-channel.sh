#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict staging legacy edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=157
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-blue}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
