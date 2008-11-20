-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (rank, owner, count, label, ratio) VALUES (86, 'green', 63, 'latest', 22.51);
INSERT INTO commits_records (rank, owner, count, label, ratio) VALUES (68, 'standard', 52, 'local', 51.02);
