-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    owner TEXT NOT NULL,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (active, rank, owner, token, ratio) VALUES (74, 62, 'strict', 'primary', 57.75);
INSERT INTO commits_records (active, rank, owner, token, ratio) VALUES (21, 71, 'cached', 'fallback', 30.15);
INSERT INTO commits_records (active, rank, owner, token, ratio) VALUES (77, 31, 'standard', 'primary', 37.98);
