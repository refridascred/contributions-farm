#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-standard}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in edge eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=116
log "limit is ${CHANNEL_LIMIT}"
