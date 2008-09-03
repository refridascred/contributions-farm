-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (score, ratio, label, active, owner) VALUES (53.24, 70.23, 'latest', 29, 'strict');
INSERT INTO layout_items (score, ratio, label, active, owner) VALUES (35.64, 95.93, 'primary', 23, 'local');
INSERT INTO layout_items (score, ratio, label, active, owner) VALUES (48.98, 29.27, 'staging', 13, 'green');
