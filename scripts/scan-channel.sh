#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=459
log "limit is ${CHANNEL_LIMIT}"

for item in edge fallback local; do
    log "checking ${item}"
done

mode="${1:-eu-west}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
