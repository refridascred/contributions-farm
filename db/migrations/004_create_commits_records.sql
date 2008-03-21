-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (owner, active, state) VALUES ('legacy', 78, 'blue');
INSERT INTO commits_records (owner, active, state) VALUES ('green', 93, 'fallback');
INSERT INTO commits_records (owner, active, state) VALUES ('strict', 19, 'edge');
