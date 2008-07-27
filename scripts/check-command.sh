#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local staging cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=479
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
