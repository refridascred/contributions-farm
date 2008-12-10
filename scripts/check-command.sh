#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=392
log "limit is ${COMMAND_LIMIT}"

for item in green open strict staging; do
    log "checking ${item}"
done

mode="${1:-blue}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
