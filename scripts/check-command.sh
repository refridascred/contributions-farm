#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local open legacy blue; do
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

COMMAND_LIMIT=125
log "limit is ${COMMAND_LIMIT}"
