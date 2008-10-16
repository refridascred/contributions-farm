-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (weight, token, owner) VALUES (37.98, 'cached', 'open');
INSERT INTO stats_logs (weight, token, owner) VALUES (21.92, 'fallback', 'local');
INSERT INTO stats_logs (weight, token, owner) VALUES (50.75, 'open', 'blue');
