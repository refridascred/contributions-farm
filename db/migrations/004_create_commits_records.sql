-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (rank, active, weight, label) VALUES (21, 20, 40.33, 'strict');
INSERT INTO commits_records (rank, active, weight, label) VALUES (70, 30, 50.41, 'latest');
