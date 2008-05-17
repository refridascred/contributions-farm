-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (ratio, active, region, score) VALUES (48.35, 31, 'cached', 70.23);
