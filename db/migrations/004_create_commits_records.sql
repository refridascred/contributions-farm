-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (ratio, label, level, active) VALUES (26.91, 'primary', 57, 15);
INSERT INTO commits_records (ratio, label, level, active) VALUES (5.99, 'green', 82, 29);
INSERT INTO commits_records (ratio, label, level, active) VALUES (69.64, 'blue', 99, 33);
