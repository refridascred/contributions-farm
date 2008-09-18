#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary local open blue; do
    log "checking ${item}"
done

mode="${1:-cached}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=422
log "limit is ${COMMAND_LIMIT}"
