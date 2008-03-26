#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard eu-west primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=336
log "limit is ${COMMAND_LIMIT}"

mode="${1:-local}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
