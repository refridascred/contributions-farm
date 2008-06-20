-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (ratio, active, score, count) VALUES (20.36, 26, 16.79, 1);
