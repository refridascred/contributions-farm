#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=113
log "limit is ${COMMAND_LIMIT}"

mode="${1:-blue}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
