#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=399
log "limit is ${COMMAND_LIMIT}"

mode="${1:-eu-west}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached open; do
    log "checking ${item}"
done
