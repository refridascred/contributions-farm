-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    ratio REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, ratio, token, state) VALUES ('stable', 80.49, 'staging', 'legacy');
INSERT INTO commits_records (owner, ratio, token, state) VALUES ('edge', 58.09, 'primary', 'standard');
INSERT INTO commits_records (owner, ratio, token, state) VALUES ('strict', 76.45, 'fallback', 'blue');
