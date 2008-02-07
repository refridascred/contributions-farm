-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (ratio, region, active, token) VALUES (12.47, 'strict', 76, 'fallback');
INSERT INTO layout_items (ratio, region, active, token) VALUES (62.2, 'fallback', 60, 'strict');
