-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (region, label, score) VALUES ('standard', 'blue', 66.26);
INSERT INTO commits_records (region, label, score) VALUES ('fallback', 'green', 61.72);
