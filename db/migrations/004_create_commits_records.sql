-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (active, label, weight) VALUES (29, 'fallback', 69.37);
INSERT INTO commits_records (active, label, weight) VALUES (21, 'green', 3.28);
