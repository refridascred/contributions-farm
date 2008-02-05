#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy stable; do
    log "checking ${item}"
done

mode="${1:-blue}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=22
log "limit is ${COMMAND_LIMIT}"
