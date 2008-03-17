#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=136
log "limit is ${COMMAND_LIMIT}"

mode="${1:-latest}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
