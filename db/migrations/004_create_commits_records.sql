-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, state, rank, label, count) VALUES (16.1, 'eu-west', 21, 'legacy', 57);
INSERT INTO commits_records (weight, state, rank, label, count) VALUES (92.85, 'standard', 44, 'eu-west', 59);
INSERT INTO commits_records (weight, state, rank, label, count) VALUES (16.24, 'eu-west', 46, 'staging', 43);
