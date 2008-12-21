-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, state, label, count) VALUES ('local', 'open', 'cached', 37);
INSERT INTO stats_logs (region, state, label, count) VALUES ('green', 'stable', 'staging', 8);
INSERT INTO stats_logs (region, state, label, count) VALUES ('green', 'latest', 'strict', 2);
