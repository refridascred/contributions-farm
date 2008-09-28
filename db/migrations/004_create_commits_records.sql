-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (active, rank, ratio, owner) VALUES (50, 22, 42.14, 'legacy');
INSERT INTO commits_records (active, rank, ratio, owner) VALUES (52, 21, 69.03, 'legacy');
