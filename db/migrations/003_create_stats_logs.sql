-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (token, score, active) VALUES ('eu-west', 14.27, 25);
INSERT INTO stats_logs (token, score, active) VALUES ('cached', 81.62, 55);
INSERT INTO stats_logs (token, score, active) VALUES ('blue', 73.57, 84);
