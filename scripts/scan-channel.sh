#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open cached; do
    log "checking ${item}"
done

CHANNEL_LIMIT=143
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-staging}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
