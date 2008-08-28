-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, ratio, state, owner) VALUES (46, 78.67, 'staging', 'local');
INSERT INTO commits_records (active, ratio, state, owner) VALUES (89, 59.33, 'latest', 'cached');
INSERT INTO commits_records (active, ratio, state, owner) VALUES (7, 26.81, 'edge', 'primary');
