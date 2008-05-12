#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west primary strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=103
log "limit is ${COMMAND_LIMIT}"

mode="${1:-eu-west}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
