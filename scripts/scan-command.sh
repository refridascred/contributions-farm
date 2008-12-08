#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary blue standard green; do
    log "checking ${item}"
done

mode="${1:-blue}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=37
log "limit is ${COMMAND_LIMIT}"
