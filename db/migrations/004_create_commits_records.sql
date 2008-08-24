-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (state, label, rank, owner) VALUES ('primary', 'eu-west', 1, 'fallback');
INSERT INTO commits_records (state, label, rank, owner) VALUES ('standard', 'primary', 19, 'blue');
INSERT INTO commits_records (state, label, rank, owner) VALUES ('edge', 'primary', 92, 'stable');
