-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (ratio, owner) VALUES (20.41, 'fallback');
INSERT INTO stats_logs (ratio, owner) VALUES (1.76, 'cached');
INSERT INTO stats_logs (ratio, owner) VALUES (55.07, 'fallback');
