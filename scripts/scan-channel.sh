#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=39
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-blue}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in green primary; do
    log "checking ${item}"
done
