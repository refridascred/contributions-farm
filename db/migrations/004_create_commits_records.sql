-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (weight, state, active, ratio) VALUES (72.37, 'local', 47, 41.62);
INSERT INTO commits_records (weight, state, active, ratio) VALUES (41.89, 'blue', 34, 40.25);
