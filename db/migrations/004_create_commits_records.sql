-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    owner TEXT NOT NULL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (ratio, rank, owner, label, weight) VALUES (48.54, 94, 'cached', 'strict', 64.12);
INSERT INTO commits_records (ratio, rank, owner, label, weight) VALUES (61.99, 95, 'green', 'stable', 69.99);
