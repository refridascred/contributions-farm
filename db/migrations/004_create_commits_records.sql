-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (active, weight) VALUES (16, 20.15);
INSERT INTO commits_records (active, weight) VALUES (80, 80.15);
INSERT INTO commits_records (active, weight) VALUES (91, 76.25);
