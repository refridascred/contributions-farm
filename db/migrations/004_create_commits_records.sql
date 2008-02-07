-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (level, rank, owner, state, label) VALUES (3, 73, 'eu-west', 'primary', 'fallback');
