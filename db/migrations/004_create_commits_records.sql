-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (owner, count, token) VALUES ('cached', 48, 'primary');
INSERT INTO commits_records (owner, count, token) VALUES ('primary', 0, 'fallback');
INSERT INTO commits_records (owner, count, token) VALUES ('strict', 45, 'standard');
