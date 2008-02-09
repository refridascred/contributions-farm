-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (level, state, weight, owner) VALUES (7, 'edge', 64.1, 'standard');
INSERT INTO commits_records (level, state, weight, owner) VALUES (66, 'fallback', 93.34, 'primary');
INSERT INTO commits_records (level, state, weight, owner) VALUES (69, 'primary', 15.12, 'open');
