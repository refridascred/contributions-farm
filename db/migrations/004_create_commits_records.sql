-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (ratio, weight, state, active) VALUES (55.02, 14.96, 'primary', 77);
INSERT INTO commits_records (ratio, weight, state, active) VALUES (74.72, 10.32, 'strict', 54);
INSERT INTO commits_records (ratio, weight, state, active) VALUES (53.43, 49.11, 'cached', 8);
