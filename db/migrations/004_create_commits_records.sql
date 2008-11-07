-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (level, label, active, weight) VALUES (80, 'staging', 0, 71.64);
INSERT INTO commits_records (level, label, active, weight) VALUES (60, 'fallback', 10, 57.44);
INSERT INTO commits_records (level, label, active, weight) VALUES (81, 'legacy', 46, 78.69);
