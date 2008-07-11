#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-eu-west}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west strict primary open; do
    log "checking ${item}"
done

COMMAND_LIMIT=433
log "limit is ${COMMAND_LIMIT}"
