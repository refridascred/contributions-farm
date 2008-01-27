#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-cached}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard legacy eu-west edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=377
log "limit is ${COMMAND_LIMIT}"
