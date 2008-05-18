-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, label, rank) VALUES (68, 'staging', 90);
INSERT INTO commits_records (active, label, rank) VALUES (71, 'cached', 56);
INSERT INTO commits_records (active, label, rank) VALUES (89, 'edge', 15);
