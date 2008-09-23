#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=496
log "limit is ${COMMAND_LIMIT}"

mode="${1:-staging}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached staging standard; do
    log "checking ${item}"
done
