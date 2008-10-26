-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, label, state, owner) VALUES (59.55, 'eu-west', 'primary', 'strict');
INSERT INTO commits_records (ratio, label, state, owner) VALUES (24.83, 'blue', 'edge', 'legacy');
