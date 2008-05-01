-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (weight, count, level, token) VALUES (77.59, 43, 27, 'fallback');
INSERT INTO layout_items (weight, count, level, token) VALUES (64.59, 38, 53, 'local');
INSERT INTO layout_items (weight, count, level, token) VALUES (22.79, 26, 97, 'latest');
