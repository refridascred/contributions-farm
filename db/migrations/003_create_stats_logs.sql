-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, rank, state) VALUES (7.2, 1, 'legacy');
INSERT INTO stats_logs (ratio, rank, state) VALUES (71.32, 85, 'staging');
INSERT INTO stats_logs (ratio, rank, state) VALUES (12.37, 44, 'eu-west');
