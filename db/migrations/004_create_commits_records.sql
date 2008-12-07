-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, count, label) VALUES (18, 81, 'open');
INSERT INTO commits_records (rank, count, label) VALUES (6, 3, 'fallback');
INSERT INTO commits_records (rank, count, label) VALUES (95, 43, 'blue');
