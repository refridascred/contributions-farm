#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-local}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open eu-west green; do
    log "checking ${item}"
done

COMMAND_LIMIT=489
log "limit is ${COMMAND_LIMIT}"
