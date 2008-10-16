#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable cached edge staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=35
log "limit is ${COMMAND_LIMIT}"

mode="${1:-latest}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
