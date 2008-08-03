-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, label, region, token) VALUES (55, 'fallback', 'staging', 'legacy');
INSERT INTO layout_items (count, label, region, token) VALUES (45, 'primary', 'cached', 'fallback');
INSERT INTO layout_items (count, label, region, token) VALUES (93, 'strict', 'legacy', 'blue');
