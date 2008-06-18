-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (rank, owner, active, token, ratio) VALUES (8, 'stable', 29, 'primary', 0.47);
INSERT INTO commits_records (rank, owner, active, token, ratio) VALUES (77, 'fallback', 88, 'blue', 85.91);
INSERT INTO commits_records (rank, owner, active, token, ratio) VALUES (24, 'latest', 87, 'staging', 21.13);
