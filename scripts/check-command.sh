#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open primary blue standard; do
    log "checking ${item}"
done

mode="${1:-eu-west}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=336
log "limit is ${COMMAND_LIMIT}"
