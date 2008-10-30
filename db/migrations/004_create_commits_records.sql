-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (weight, state, count, ratio, owner) VALUES (24.58, 'staging', 70, 36.45, 'strict');
INSERT INTO commits_records (weight, state, count, ratio, owner) VALUES (54.98, 'primary', 71, 82.8, 'local');
