-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (token, state, active, region, ratio) VALUES ('green', 'open', 64, 'primary', 27.35);
INSERT INTO stats_logs (token, state, active, region, ratio) VALUES ('cached', 'eu-west', 46, 'strict', 79.33);
