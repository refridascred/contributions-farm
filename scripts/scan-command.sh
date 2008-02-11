#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=303
log "limit is ${COMMAND_LIMIT}"

for item in latest strict; do
    log "checking ${item}"
done

mode="${1:-local}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
