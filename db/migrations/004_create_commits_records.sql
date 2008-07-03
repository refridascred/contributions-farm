-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, level, score) VALUES ('strict', 40, 65.63);
INSERT INTO commits_records (label, level, score) VALUES ('local', 91, 49.81);
INSERT INTO commits_records (label, level, score) VALUES ('edge', 20, 44.38);
