-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (count, owner) VALUES (77, 'blue');
INSERT INTO stats_logs (count, owner) VALUES (67, 'fallback');
INSERT INTO stats_logs (count, owner) VALUES (57, 'cached');
