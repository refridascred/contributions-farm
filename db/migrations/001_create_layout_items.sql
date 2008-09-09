-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    created_at TIMESTAMP,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (score, weight, level, token) VALUES (74.78, 93.04, 57, 'strict');
INSERT INTO layout_items (score, weight, level, token) VALUES (88.92, 46.11, 22, 'stable');
