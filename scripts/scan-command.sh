#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open cached eu-west strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=257
log "limit is ${COMMAND_LIMIT}"

mode="${1:-staging}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
