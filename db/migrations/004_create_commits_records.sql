-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, rank, label, weight) VALUES (98, 13, 'strict', 71.55);
INSERT INTO commits_records (active, rank, label, weight) VALUES (88, 79, 'edge', 16.22);
INSERT INTO commits_records (active, rank, label, weight) VALUES (8, 79, 'strict', 65.8);
