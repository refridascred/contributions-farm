-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, weight) VALUES (49, 13.32);
INSERT INTO commits_records (active, weight) VALUES (48, 60.46);
INSERT INTO commits_records (active, weight) VALUES (90, 53.02);
