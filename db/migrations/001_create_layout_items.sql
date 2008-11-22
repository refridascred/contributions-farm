-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (weight, count, token, active, region) VALUES (0.11, 47, 'cached', 84, 'fallback');
INSERT INTO layout_items (weight, count, token, active, region) VALUES (43.02, 49, 'blue', 74, 'green');
