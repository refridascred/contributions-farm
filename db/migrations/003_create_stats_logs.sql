-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (state, ratio) VALUES ('cached', 4.34);
INSERT INTO stats_logs (state, ratio) VALUES ('primary', 2.87);
INSERT INTO stats_logs (state, ratio) VALUES ('cached', 88.64);
