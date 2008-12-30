-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (region, score, active, label) VALUES ('local', 33.99, 13, 'local');
INSERT INTO commits_records (region, score, active, label) VALUES ('eu-west', 51.11, 64, 'primary');
INSERT INTO commits_records (region, score, active, label) VALUES ('staging', 60.97, 29, 'fallback');
