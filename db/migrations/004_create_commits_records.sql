-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (ratio, label, count, state) VALUES (43.01, 'green', 97, 'standard');
INSERT INTO commits_records (ratio, label, count, state) VALUES (52.42, 'legacy', 62, 'stable');
INSERT INTO commits_records (ratio, label, count, state) VALUES (78.11, 'cached', 42, 'stable');
