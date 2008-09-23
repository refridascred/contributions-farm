-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, ratio, owner) VALUES ('fallback', 60.98, 'legacy');
INSERT INTO commits_records (label, ratio, owner) VALUES ('cached', 50.11, 'cached');
