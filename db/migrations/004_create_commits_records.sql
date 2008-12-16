-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (level, state, label, token) VALUES (77, 'blue', 'eu-west', 'cached');
INSERT INTO commits_records (level, state, label, token) VALUES (71, 'open', 'standard', 'fallback');
