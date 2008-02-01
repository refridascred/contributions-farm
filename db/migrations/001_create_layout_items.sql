-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, ratio, token) VALUES (76, 95.92, 'strict');
INSERT INTO layout_items (level, ratio, token) VALUES (86, 7.12, 'stable');
INSERT INTO layout_items (level, ratio, token) VALUES (82, 85.49, 'fallback');
