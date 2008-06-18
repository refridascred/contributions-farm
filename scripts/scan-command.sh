#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green strict latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=257
log "limit is ${COMMAND_LIMIT}"

mode="${1:-blue}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
