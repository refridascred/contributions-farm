-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, level, rank, state) VALUES ('fallback', 15, 2, 'primary');
INSERT INTO commits_records (label, level, rank, state) VALUES ('open', 56, 28, 'open');
INSERT INTO commits_records (label, level, rank, state) VALUES ('blue', 93, 63, 'cached');
