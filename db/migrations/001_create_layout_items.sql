-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (count, ratio, region, state) VALUES (54, 98.17, 'blue', 'blue');
INSERT INTO layout_items (count, ratio, region, state) VALUES (7, 85.49, 'eu-west', 'local');
INSERT INTO layout_items (count, ratio, region, state) VALUES (3, 56.2, 'strict', 'fallback');
