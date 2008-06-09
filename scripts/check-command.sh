#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=22
log "limit is ${COMMAND_LIMIT}"

for item in edge green; do
    log "checking ${item}"
done

mode="${1:-blue}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
