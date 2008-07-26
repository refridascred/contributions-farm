-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (label, token, active, weight) VALUES ('local', 'staging', 74, 34.67);
INSERT INTO commits_records (label, token, active, weight) VALUES ('staging', 'open', 90, 54.96);
INSERT INTO commits_records (label, token, active, weight) VALUES ('legacy', 'latest', 45, 57.29);
