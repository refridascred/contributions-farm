-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (score, weight, state) VALUES (95.42, 23.14, 'legacy');
INSERT INTO stats_logs (score, weight, state) VALUES (59.84, 15.23, 'cached');
INSERT INTO stats_logs (score, weight, state) VALUES (54.21, 4.83, 'eu-west');
