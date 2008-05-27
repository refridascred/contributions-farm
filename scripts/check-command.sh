#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-standard}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west cached staging open; do
    log "checking ${item}"
done

COMMAND_LIMIT=306
log "limit is ${COMMAND_LIMIT}"
