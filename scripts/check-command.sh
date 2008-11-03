#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached eu-west; do
    log "checking ${item}"
done

mode="${1:-local}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=130
log "limit is ${COMMAND_LIMIT}"
