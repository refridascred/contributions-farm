-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (rank, owner, active, label) VALUES (74, 'green', 87, 'cached');
INSERT INTO commits_records (rank, owner, active, label) VALUES (1, 'latest', 18, 'legacy');
