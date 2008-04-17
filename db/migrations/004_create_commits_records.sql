-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    owner TEXT NOT NULL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, rank, owner, label, state) VALUES (11.08, 11, 'latest', 'eu-west', 'primary');
INSERT INTO commits_records (ratio, rank, owner, label, state) VALUES (81.11, 89, 'fallback', 'strict', 'cached');
