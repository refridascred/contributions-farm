-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (state, ratio) VALUES ('standard', 52.66);
INSERT INTO stats_logs (state, ratio) VALUES ('latest', 37.66);
INSERT INTO stats_logs (state, ratio) VALUES ('latest', 15.97);
