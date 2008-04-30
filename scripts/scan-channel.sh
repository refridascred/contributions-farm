#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-fallback}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=268
log "limit is ${CHANNEL_LIMIT}"

for item in cached open eu-west; do
    log "checking ${item}"
done
