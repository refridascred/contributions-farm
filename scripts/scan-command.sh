#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard legacy staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=52
log "limit is ${COMMAND_LIMIT}"

mode="${1:-blue}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
