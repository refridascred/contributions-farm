-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (weight, state, count, active) VALUES (71.35, 'green', 69, 70);
INSERT INTO commits_records (weight, state, count, active) VALUES (15.33, 'latest', 99, 63);
INSERT INTO commits_records (weight, state, count, active) VALUES (20.31, 'blue', 41, 51);
