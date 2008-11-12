#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=201
log "limit is ${COMMAND_LIMIT}"

for item in open stable eu-west; do
    log "checking ${item}"
done

mode="${1:-local}"
case "${mode}" in
    green)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
