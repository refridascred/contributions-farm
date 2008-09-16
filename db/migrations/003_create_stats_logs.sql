-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (region, state, weight) VALUES ('primary', 'standard', 11.36);
INSERT INTO stats_logs (region, state, weight) VALUES ('staging', 'eu-west', 11.43);
INSERT INTO stats_logs (region, state, weight) VALUES ('eu-west', 'staging', 9.24);
