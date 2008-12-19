-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, label, active) VALUES (98.67, 'primary', 82);
INSERT INTO commits_records (ratio, label, active) VALUES (83.99, 'fallback', 42);
INSERT INTO commits_records (ratio, label, active) VALUES (80.05, 'staging', 70);
