-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (level, region, active, weight, state) VALUES (45, 'primary', 73, 0.43, 'eu-west');
INSERT INTO commits_records (level, region, active, weight, state) VALUES (76, 'strict', 41, 54.62, 'fallback');
INSERT INTO commits_records (level, region, active, weight, state) VALUES (30, 'legacy', 14, 94.56, 'local');
