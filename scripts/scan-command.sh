#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=155
log "limit is ${COMMAND_LIMIT}"

for item in standard legacy; do
    log "checking ${item}"
done

mode="${1:-eu-west}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
