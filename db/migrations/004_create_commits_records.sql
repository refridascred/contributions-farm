-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (weight, rank, state, label, count) VALUES (18.68, 12, 'stable', 'standard', 4);
INSERT INTO commits_records (weight, rank, state, label, count) VALUES (30.37, 58, 'blue', 'eu-west', 60);
