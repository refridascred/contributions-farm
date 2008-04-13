#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard green stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=495
log "limit is ${COMMAND_LIMIT}"

mode="${1:-blue}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
