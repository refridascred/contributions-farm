#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-eu-west}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in latest eu-west edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=190
log "limit is ${COMMAND_LIMIT}"
