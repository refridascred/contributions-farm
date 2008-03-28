-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, owner, level, state) VALUES ('standard', 'eu-west', 3, 'local');
INSERT INTO commits_records (label, owner, level, state) VALUES ('legacy', 'eu-west', 27, 'primary');
