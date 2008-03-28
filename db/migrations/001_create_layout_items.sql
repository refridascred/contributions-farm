-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    level INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (ratio, level, token, count) VALUES (96.54, 56, 'primary', 40);
INSERT INTO layout_items (ratio, level, token, count) VALUES (20.67, 69, 'edge', 23);
INSERT INTO layout_items (ratio, level, token, count) VALUES (78.52, 6, 'cached', 60);
