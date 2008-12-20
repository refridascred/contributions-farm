-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (weight, label, count, active) VALUES (78.02, 'legacy', 2, 26);
INSERT INTO commits_records (weight, label, count, active) VALUES (28.63, 'legacy', 82, 7);
INSERT INTO commits_records (weight, label, count, active) VALUES (63.9, 'eu-west', 80, 45);
