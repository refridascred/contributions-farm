-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (level, weight, active) VALUES (66, 39.54, 72);
INSERT INTO commits_records (level, weight, active) VALUES (6, 16.25, 54);
INSERT INTO commits_records (level, weight, active) VALUES (46, 89.64, 7);
