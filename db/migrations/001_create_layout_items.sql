-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (ratio, count, level, label, token) VALUES (40.29, 4, 1, 'fallback', 'local');
INSERT INTO layout_items (ratio, count, level, label, token) VALUES (36.75, 95, 87, 'strict', 'standard');
INSERT INTO layout_items (ratio, count, level, label, token) VALUES (79.99, 19, 11, 'cached', 'cached');
