-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (state, region, weight) VALUES ('cached', 'green', 74.99);
INSERT INTO stats_logs (state, region, weight) VALUES ('fallback', 'eu-west', 18.15);
INSERT INTO stats_logs (state, region, weight) VALUES ('open', 'primary', 67.1);
