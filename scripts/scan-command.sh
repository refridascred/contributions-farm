#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy primary blue staging; do
    log "checking ${item}"
done

mode="${1:-blue}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=44
log "limit is ${COMMAND_LIMIT}"
