#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=310
log "limit is ${COMMAND_LIMIT}"

mode="${1:-green}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached open eu-west staging; do
    log "checking ${item}"
done
