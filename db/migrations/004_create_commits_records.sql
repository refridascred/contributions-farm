-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (region, active, score, label) VALUES ('cached', 26, 18.59, 'local');
INSERT INTO commits_records (region, active, score, label) VALUES ('staging', 19, 67.2, 'open');
INSERT INTO commits_records (region, active, score, label) VALUES ('legacy', 24, 37.73, 'eu-west');
