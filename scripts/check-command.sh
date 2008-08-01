#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-fallback}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in blue primary open cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=289
log "limit is ${COMMAND_LIMIT}"
