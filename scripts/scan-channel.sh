#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge blue staging; do
    log "checking ${item}"
done

CHANNEL_LIMIT=240
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-cached}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
