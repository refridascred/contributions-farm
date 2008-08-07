#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=16
log "limit is ${COMMAND_LIMIT}"

for item in standard legacy local; do
    log "checking ${item}"
done

mode="${1:-standard}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
