#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=194
log "limit is ${COMMAND_LIMIT}"

for item in cached stable eu-west; do
    log "checking ${item}"
done

mode="${1:-eu-west}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
