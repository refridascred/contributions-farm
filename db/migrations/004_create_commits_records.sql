-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, active, label) VALUES (62, 35, 'legacy');
INSERT INTO commits_records (rank, active, label) VALUES (69, 85, 'staging');
INSERT INTO commits_records (rank, active, label) VALUES (13, 7, 'fallback');
